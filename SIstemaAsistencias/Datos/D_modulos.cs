using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Datos
{
    public class D_modulos
    {
        public void mostrarModulos (ref DataTable dt)
        {
			try
			{
				Conexion.abrir();
				SqlDataAdapter da = new SqlDataAdapter("select * from Modulos", Conexion.conectar);
				da.Fill (dt);

			}
			catch (Exception e)
			{

				MessageBox.Show(e.StackTrace);
			}
			finally
			{
				Conexion.cerrar();
			}
        }
    }
}
