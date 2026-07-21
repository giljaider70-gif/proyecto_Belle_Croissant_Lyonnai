using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mis_Clases
{
    public class PreguntaSeguridadDAO : Conexion
    {

        public List<PreguntaSeguridad> Obtener_PreguntasSeguridad()
        {
            List<PreguntaSeguridad> lista_preguntaSeguridad = new List<PreguntaSeguridad>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select * from PreguntaSeguridad;";

                using (SqlCommand comado = new SqlCommand(consulta, conexion))
                {
                    comado.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comado.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            PreguntaSeguridad preguntaSeguridad = new PreguntaSeguridad
                            {
                                IdPregunta = Convert.ToInt32(rider["IdPregunta"]),
                                Pregunta = rider["Pregunta"].ToString(),
                            };
                            lista_preguntaSeguridad.Add(preguntaSeguridad);
                        }
                    }
                }
            }
            return lista_preguntaSeguridad;


        }

        public string ObtenerPreguntaPorUsuario(int idUsuario)
        {
            string pregunta = "";

            using (SqlConnection conexion = Obtener_Conexion())
            {
                // Consulta haciendo JOIN entre Usuario y PreguntaSeguridad
                string query = @"SELECT p.Pregunta 
                        FROM Usuario u
                        INNER JOIN PreguntaSeguridad p ON u.IdPregunta = p.IdPregunta
                        WHERE u.IdUsuario = @Id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", idUsuario);

                conexion.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    pregunta = resultado.ToString();
                }
            }

            return pregunta;
        }
    }
}
