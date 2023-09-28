using SIstemaAsistencias.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Datos
{
    public class D_usuarios
    {
        public bool insertar_usuarios(L_usuarios parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insertar_usuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", parametros.nombres);
                cmd.Parameters.AddWithValue("@Login", parametros.login);
                cmd.Parameters.AddWithValue("@Password", parametros.password);
                cmd.Parameters.AddWithValue("@Icono", parametros.icono);
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex + ex.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void mostrar_usuarios(ref DataTable dt)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select * from Usuarios", Conexion.conectar);
                da.Fill(dt);

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
        public void obtener_id_usuario(ref int id_usuario, string login)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("obtener_id_usuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@login", login);
                id_usuario= Convert.ToInt32( cmd.ExecuteScalar());

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
