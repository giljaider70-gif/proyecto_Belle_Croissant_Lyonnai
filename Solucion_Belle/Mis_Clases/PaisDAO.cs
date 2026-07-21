using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Mis_Clases
{
    public class PaisDAO : Conexion
    {

        public List<Pais> Mostra_Pais()
        {
            List<Pais> lista_pais = new List<Pais>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select * from Pais;";

                using (SqlCommand comado = new SqlCommand(consulta, conexion))
                {
                    comado.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comado.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            Pais pais = new Pais
                            {
                               IdPais = Convert.ToInt32(rider["IdPais"]),
                               NombrePais = rider["Nombre"].ToString(),
                            };
                            lista_pais.Add(pais);
                        }
                    }
                }
            }
            return lista_pais;


        }
    }
}
