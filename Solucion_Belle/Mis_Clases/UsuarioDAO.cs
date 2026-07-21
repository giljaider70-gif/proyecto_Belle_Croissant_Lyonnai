using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Mis_Clases
{
    public class UsuarioDAO : Conexion
    {
        public List<Usuario> Mostra_Usuario()
        {
            List<Usuario> lista_Usuario = new List<Usuario>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select Usuario.idUsuario ,\r\nPreguntaSeguridad.Pregunta ,\r\nMetodoEntrega.Nombre as metodoEntrega ,\r\nUsuario.Nombre ,\r\nUsuario.Apellido ,\r\nUsuario.Telefono ,\r\nUsuario.Correo ,\r\nUsuario.Contraseña ,\r\nUsuario.FotoPerfil ,\r\nUsuario.RespuestaSeguridad ,\r\nUsuario.SuscripcionListaCorreo\r\n,Rol.NombreRol from Usuario \r\n\r\njoin PreguntaSeguridad\r\non Usuario.IdPregunta = PreguntaSeguridad.IdPregunta join \r\nMetodoEntrega\r\non Usuario.IdMetodo = MetodoEntrega.IdMetodo join \r\nRol\r\non Usuario.IdRol = Rol.IdRol;\r\n";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comando.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                idUsuario = Convert.ToInt32(rider["idUsuario"]),
                                preguntaSeguridad = rider["Pregunta"].ToString(),
                                metodoEntrega = rider["metodoEntrega"].ToString(),
                                nombre = rider["Nombre"].ToString(),
                                apellido = rider["Apellido"].ToString(),
                                Telefono = rider["Telefono"].ToString(),
                                Correo = rider["Correo"].ToString(),
                                contrasena = rider["Contraseña"].ToString(),
                                FotoPerfil = rider["FotoPerfil"] != DBNull.Value
                                    ? (byte[])rider["FotoPerfil"]
                                    : null,
                                respuestaSeguridad = rider["RespuestaSeguridad"].ToString(),
                                SuscripcionListaCorreo = Convert.ToBoolean(rider["SuscripcionListaCorreo"]),
                                rol = rider["NombreRol"].ToString(),

                            };
                            lista_Usuario.Add(usuario);
                        }
                    }
                }
            }
            return lista_Usuario;
        }


        public Usuario ValidarLogin(string correo, string contrasena)
        {
            // 1. Empezamos en null (la caja vacía) por si las credenciales están mal
            Usuario usuarioLogueado = null;

            // 2. Definimos la consulta con JOINs para traer la información humana (Rol, Pregunta, etc.)
            string consulta = @"SELECT Usuario.idUsuario,
                               PreguntaSeguridad.Pregunta,
                               MetodoEntrega.Nombre AS metodoEntrega,
                               Usuario.Nombre,
                               Usuario.Apellido,
                               Usuario.Telefono,
                               Usuario.Correo,
                               Usuario.Contraseña,
                               Usuario.FotoPerfil,
                               Usuario.RespuestaSeguridad,
                               Usuario.SuscripcionListaCorreo,
                               Rol.NombreRol 
                        FROM Usuario 
                        JOIN PreguntaSeguridad ON Usuario.IdPregunta = PreguntaSeguridad.IdPregunta 
                        JOIN MetodoEntrega ON Usuario.IdMetodo = MetodoEntrega.IdMetodo 
                        JOIN Rol ON Usuario.IdRol = Rol.IdRol
                        WHERE Usuario.Correo = @Correo AND Usuario.Contraseña = @Contrasena;";

            // 3. Abrimos la conexión usando tu método 'Obtener_Conexion()'
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    // 4. Pasamos los parámetros de forma segura para evitar inyección SQL
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    // 5. Ejecutamos la consulta
                    using (SqlDataReader rider = comando.ExecuteReader())
                    {
                        // Si la base de datos encuentra una coincidencia exacta de correo y clave
                        if (rider.Read())
                        {
                            // ¡Aquí es donde ocurre el 'new'! Creamos el objeto con sus datos reales
                            usuarioLogueado = new Usuario
                            {
                                idUsuario = Convert.ToInt32(rider["idUsuario"]),
                                preguntaSeguridad = rider["Pregunta"].ToString(),
                                metodoEntrega = rider["metodoEntrega"].ToString(),
                                nombre = rider["Nombre"].ToString(),
                                apellido = rider["Apellido"].ToString(),
                                Telefono = rider["Telefono"].ToString(),
                                Correo = rider["Correo"].ToString(),
                                contrasena = rider["Contraseña"].ToString(),
                                FotoPerfil = rider["FotoPerfil"] != DBNull.Value
                                    ? (byte[])rider["FotoPerfil"]
                                    : null,
                                respuestaSeguridad = rider["RespuestaSeguridad"].ToString(),
                                SuscripcionListaCorreo = Convert.ToBoolean(rider["SuscripcionListaCorreo"]),
                                rol = rider["NombreRol"].ToString()
                            };
                        }
                    }
                }
            }

            // 6. Retornamos el objeto lleno (si entró al if) o null (si falló el login)
            return usuarioLogueado;
        }

        public bool RegistrarUsuario(string nombre, string apellido, string correo, string contraseña, int idpregunta, string respuesta)
        {
            bool exito = false;

            // Ajustado exactamente a las columnas reales de tu tabla dbo.Usuario
            string query = "INSERT INTO dbo.Usuario (IdPregunta, IdMetodo, Nombre, Apellido, Correo, Contraseña, RespuestaSeguridad, SuscripcionListaCorreo, IdRol) " +
                           "VALUES (@idpregunta, 1, @nombre, @apellido, @correo, @contraseña, @respuestaSeguridad, 1, 1)";

            try
            {
                using (SqlConnection con = Obtener_Conexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Pasamos los parámetros emparejados idénticos a los del VALUES anterior
                        cmd.Parameters.AddWithValue("@idpregunta", idpregunta);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@respuestaSeguridad", respuesta);

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            exito = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }

            return exito;
        }


        // Método para actualizar la información del usuario
        public bool ActualizarUsuario(string correoActual, string nuevoNombre, string nuevoApellido, string nuevoCorreo, string nuevoTelefono)
        {
            using (SqlConnection con = Obtener_Conexion())
            {
                string query = "UPDATE Usuario SET Nombre = @nombre, Apellido = @apellido, Correo = @nuevoCorreo, Telefono = @telefono WHERE Correo = @correoActual";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@apellido", nuevoApellido);
                    cmd.Parameters.AddWithValue("@nuevoCorreo", nuevoCorreo);
                    // Si el teléfono está vacío, enviamos DBNull para que guarde NULL
                    cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(nuevoTelefono) ? (object)DBNull.Value : nuevoTelefono);
                    cmd.Parameters.AddWithValue("@correoActual", correoActual);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // Si modificó al menos 1 fila, retorna true (éxito)
                    return filasAfectadas > 0;
                }
            }
        }

        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            Usuario usuarioEncontrado = null;

            using (SqlConnection con = Obtener_Conexion())
            {
                // Consulta SQL para traer todos los datos del usuario por su correo
                string query = "SELECT Nombre, Apellido, Correo, Telefono FROM Usuario WHERE Correo = @correo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Creamos el objeto Usuario con los datos de la BD
                            usuarioEncontrado = new Usuario
                            {
                                nombre = reader["Nombre"].ToString(),
                                apellido = reader["Apellido"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Telefono = reader["Telefono"] != DBNull.Value ? reader["Telefono"].ToString() : ""
                            };
                        }
                    }
                }
            }

            return usuarioEncontrado;
        }

        public bool ValidarRespuestaSeguridad(int idUsuario, string respuesta)
        {
            bool esCorrecta = false;
            string query = "SELECT COUNT(*) FROM Usuario WHERE idUsuario = @idUsuario AND RespuestaSeguridad = @respuesta";

            using (SqlConnection con = Obtener_Conexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@respuesta", respuesta);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        esCorrecta = true;
                    }
                }
            }
            return esCorrecta;
        }

        // Método 2: Actualizar la contraseña del usuario por su ID
        public bool ActualizarContrasena(int idUsuario, string nuevaContrasena)
        {
            using (SqlConnection con = Obtener_Conexion())
            {
                string query = "UPDATE Usuario SET Contraseña = @nuevaContrasena WHERE idUsuario = @idUsuario";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nuevaContrasena", nuevaContrasena);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public int ObtenerIdPorCorreo(string correo)
        {
            int idUsuario = 0;
            // Cambiado 'CorreoElectronico' por 'Correo' para coincidir con tu BD
            string query = "SELECT idUsuario FROM Usuario WHERE Correo = @Correo";

            using (SqlConnection conexion = Obtener_Conexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    try
                    {
                        conexion.Open();
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null && resultado != DBNull.Value)
                        {
                            idUsuario = Convert.ToInt32(resultado);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el correo: " + ex.Message);
                    }
                }
            }

            return idUsuario;
        }

        public bool ActualizarFotoPerfil(string correo, byte[] foto)
        {
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();

                string sql = "UPDATE Usuario SET FotoPerfil = @Foto WHERE Correo = @Correo";

                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {

                    cmd.Parameters.AddWithValue("@Foto", foto);
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    int filas = cmd.ExecuteNonQuery();

                    conexion.Close();

                    return filas > 0;
                }
            }

            
        }
    }

}
