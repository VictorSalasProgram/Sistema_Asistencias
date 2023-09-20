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
    public class D_cargos
    {
        public bool usp_insertar_cargo(L_cargos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_insertar_cargo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cargo", parametros.cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public bool usp_editar_cargo(L_cargos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_editar_cargo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.id_cargo);
                cmd.Parameters.AddWithValue("@cargo", parametros.cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldoPorHora);
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
        public void usp_buscar_cargo(ref DataTable dt, string buscador) 
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("usp_buscar_cargo", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
