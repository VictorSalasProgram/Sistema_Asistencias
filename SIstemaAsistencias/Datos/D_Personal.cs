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

        public void usp_mostrar_personal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("usp_mostrar_personal", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
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
        public void usp_buscar_personal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("usp_buscar_personal", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
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
