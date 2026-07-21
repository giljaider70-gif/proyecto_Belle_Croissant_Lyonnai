using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mis_Clases
{
    public class DireccionDAO : Conexion
    {
        public List<Direccion> Mostra_Direccion()
        {
            List<Direccion> lista_direccion = new List<Direccion>();
            using (SqlConnection conexion = Obtener_Conexion())
            {
                conexion.Open();
                string consulta = "select Direccion.idDireccion , Ciudad.Nombre as NombreCiudad , Direccion.Direccion as Direccion_casa,\r\nDireccion.CodigoPostal , Direccion.EsPreferida from Direccion\r\njoin Ciudad\r\non Direccion.IdCiudad =  Ciudad.IdCiudad;";

                using (SqlCommand comado = new SqlCommand(consulta, conexion))
                {
                    comado.CommandType = CommandType.Text;
                    using (SqlDataReader rider = comado.ExecuteReader())
                    {
                        while (rider.Read())
                        {
                            Direccion direccion = new Direccion
                            {
                                IdDireccion = Convert.ToInt32(rider["IdDireccion"]),
                                Nombre = rider["Nombre"].ToString(),
                                Direccion_Casa = rider["Direccion"].ToString(),
                                CodigoPostal = rider["CodigoPostal"].ToString(),
                                EsPreferida = rider["EsPreferida"].ToString(),
                            };
                            lista_direccion.Add(direccion);
                        }
                    }
                }
            }
            return lista_direccion;


        }
    }
    
}
