using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SIstemaAsistencias.Datos
{
    public class Conexion
    {
        public static string Con = @"Data source=VICTORPC666\\SQLEXPRESS; Initial Catalog=SistemaAsistencias1; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(Con);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
