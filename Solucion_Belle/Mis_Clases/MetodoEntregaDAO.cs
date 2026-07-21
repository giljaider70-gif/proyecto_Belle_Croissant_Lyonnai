using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mis_Clases
{
    public class MetodoEntregaDAO : Conexion
    {

        public List<MetodoEntrega> Mostra_Pais()
        {
            List<MetodoEntrega> lista_metodoEntrega = new List<MetodoEntrega>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select * from MetodoEntrega;";

                using (SqlCommand comado = new SqlCommand(consulta, conexion))
                {
                    comado.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comado.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            MetodoEntrega metodoEntrega = new MetodoEntrega
                            {
                                IdMetodo = Convert.ToInt32(rider["IdPais"]),
                                Nombre = rider["Nombre"].ToString(),
                            };
                            lista_metodoEntrega.Add(metodoEntrega);
                        }
                    }
                }
            }
            return lista_metodoEntrega;


        }
    }
}
