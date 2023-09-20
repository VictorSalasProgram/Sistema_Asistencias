using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SIstemaAsistencias.Logica;
using System.Windows.Forms;

namespace SIstemaAsistencias.Datos
{
    public class D_Personal
    {
        public bool usp_insertar_personal(L_personal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_insertar_personal", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", parametros.nombres);
                cmd.Parameters.AddWithValue("@identificacion", parametros.identificacion);
                cmd.Parameters.AddWithValue("@pais", parametros.pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.id_cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex + ex.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public bool usp_editar_personal(L_personal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_editar_personal", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.id_personal);
                cmd.Parameters.AddWithValue("@nombre", parametros.nombres);
                cmd.Parameters.AddWithValue("@identificacion", parametros.identificacion);
                cmd.Parameters.AddWithValue("@pais", parametros.pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.id_cargo);
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
        public bool usp_eliminar_personal(L_personal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_eliminar_personal", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.id_personal);
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
    }
}
