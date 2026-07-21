using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace Mis_Clases
{
    public class Conexion
    {

        private readonly string? cadena_de_conexion;

        public Conexion()
        {

            cadena_de_conexion = ConfigurationManager.ConnectionStrings["MyConexionSQL"].ConnectionString;
        }
        public SqlConnection Obtener_Conexion()
        {
            return new SqlConnection(cadena_de_conexion);
        }


    }

}
