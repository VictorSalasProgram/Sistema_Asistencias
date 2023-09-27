using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIstemaAsistencias.Logica;
using System.Net.Configuration;

namespace SIstemaAsistencias.Datos
{
    public class D_asistencias
    {
        public void usp_buscar_asistencias_id(ref DataTable dt, int id_personal)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("usp_buscar_asistencias_id", Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_personal", id_personal);
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
        public bool insertarAsistencias(L_asistencias parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_insertar_asistencias",Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.id_personal);
                cmd.Parameters.AddWithValue("@fecha_entrada", parametros.fecha_entrada);
                cmd.Parameters.AddWithValue("@fecha_salida", parametros.fecha_salida);
                cmd.Parameters.AddWithValue("@estado", parametros.estado);
                cmd.Parameters.AddWithValue("@horas", parametros.horas);
                cmd.Parameters.AddWithValue("@observacion", parametros.observacion);
                cmd. ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public bool usp_confirmar_salida(L_asistencias parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("usp_confirmar_salida", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.id_personal);
                cmd.Parameters.AddWithValue("@fecha_salida", parametros.fecha_salida);
                cmd.Parameters.AddWithValue("@horas", parametros.horas);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
