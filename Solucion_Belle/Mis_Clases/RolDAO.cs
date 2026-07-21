using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mis_Clases
{
    public class RolDAO : Conexion
    {

        public List<Rol> Mostra_Pais()
        {
            List<Rol> lista_pais = new List<Rol>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select * from Rol;";

                using (SqlCommand comado = new SqlCommand(consulta, conexion))
                {
                    comado.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comado.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            Rol rol = new Rol
                            {
                                IdRol = Convert.ToInt32(rider["IdRol"]),
                                NombreRol = rider["NombreRol"].ToString(),
                            };
                            lista_pais.Add(rol);
                        }
                    }
                }
            }
            return lista_pais;

        }
    }
}
