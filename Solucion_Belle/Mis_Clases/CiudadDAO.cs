using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mis_Clases
{
    public class CiudadDAO : Conexion
    {
        public List<Ciudad> Mostra_Ciudad()
        {
            List<Ciudad> lista_ciudad = new List<Ciudad>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select * from Ciudad;";

                using (SqlCommand comado = new SqlCommand(consulta, conexion))
                {
                    comado.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comado.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            Ciudad ciudad = new Ciudad
                            {
                                IdCiudad = Convert.ToInt32(rider["IdCiudad"]),
                                IdPais = Convert.ToInt32(rider["IdPais"]),
                                Nombre = rider["Nombre"].ToString(),
                            };
                            lista_ciudad.Add(ciudad);
                        }
                    }
                }
            }
            return lista_ciudad;

        }
    }
}
