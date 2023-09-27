using SIstemaAsistencias.Datos;
using SIstemaAsistencias.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Presentacion
{
    public partial class TomarAsistencias : Form
    {
        public TomarAsistencias()
        {
            InitializeComponent();
        }
        string identificacion;
        int idPersonal;
        int contador;
        DateTime fechaReg;

        private void timer_hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void txt_identificacion_TextChanged(object sender, EventArgs e)
        {
            buscarPersonalIdentidad();
            if (identificacion== txt_identificacion.Text) 
            {
                buscar_asistencias_id();
                if (contador == 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Agregar alguna observacion?", "Observaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        pnl_observaciones.Visible = true;
                        pnl_observaciones.Location = new Point(panel2.Location.X,panel2.Location.Y);
                        pnl_observaciones.Size = new Size(panel2.Width,panel2.Height);
                        pnl_observaciones.BringToFront();
                        txt_observacion.Clear();
                        txt_observacion.Focus();
                        
                    }
                    else
                    {
                        insertarAsistencias();
                    }
                }
                else
                {
                    confirmar_salida();
                }
            }
        }
        private void confirmar_salida()
        {
            L_asistencias parametros = new L_asistencias();
            D_asistencias funcion = new D_asistencias();
            parametros.id_personal = idPersonal;
            parametros.fecha_salida = DateTime.Now;
            parametros.horas = bases.DateDiff(bases.DateInterval.Hour, fechaReg, DateTime.Now);
            if (funcion.usp_confirmar_salida(parametros)==true)
            {
                txt_aviso.Text = "SALIDA REGISTRADA";
                txt_identificacion.Clear();
                txt_identificacion.Focus();

            }
        }
        private void insertarAsistencias()
        {

            if (string.IsNullOrEmpty(txt_observacion.Text))
            {
                txt_observacion.Text = "-";
            }
            L_asistencias parametros = new L_asistencias();
            D_asistencias funcion = new D_asistencias();
            parametros.id_personal = idPersonal;
            parametros.fecha_entrada = DateTime.Now;
            parametros.fecha_salida = DateTime.Now;
            parametros.estado = "ENTRADA";
            parametros.horas = 0;
            parametros.observacion = txt_observacion.Text;
            if (funcion.insertarAsistencias(parametros)== true) 
            {
                txt_aviso.Text = "Entrada Registrada";
                txt_identificacion.Clear();
                txt_identificacion.Focus();
                pnl_observaciones.Visible = false;

            }
                
        }
        private void buscar_asistencias_id()
        {
            DataTable dt = new DataTable();
            D_asistencias funcion = new D_asistencias();
            funcion.usp_buscar_asistencias_id(ref dt,idPersonal);
            contador = dt.Rows.Count;
            if (contador >0 )
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["fecha_entrada"]);
            }
        }
        private void buscarPersonalIdentidad()
        {
            DataTable dt = new DataTable();
            D_Personal funcion = new D_Personal();
            funcion.usp_buscar_personal_identidad(ref dt, txt_identificacion.Text);
            if (dt.Rows.Count > 0)
            {
                identificacion = dt.Rows[0]["identificacion"].ToString();
                idPersonal = Convert.ToInt32( dt.Rows[0]["id_personal"]);
                txt_nombre.Text = dt.Rows[0]["nombres"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertarAsistencias();
        }
    }
}
