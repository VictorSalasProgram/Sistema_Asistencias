using SIstemaAsistencias.Datos;
using SIstemaAsistencias.Logica;
using SIstemaAsistencias.Presentacion.AsistenteInstalacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string usuario;
        int id_usuario;
        int contador;
        string indicador;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            validarConexion();
        }
        private void validarConexion()
        {
            verificarConexion();
            if (indicador =="CORRECTO")
            {
                dibujarUsuarios();
            }
            else
            {
                Dispose();
                EleccionServidor frm = new EleccionServidor();
                frm.ShowDialog();
            }
        }
        private void verificarConexion()
        {
            D_usuarios funcion = new D_usuarios();
            funcion.verificarUsuarios(ref indicador);
        }
        private void dibujarUsuarios()
        {
            try
            {

                pnl_usuarios.Visible = true;
                pnl_usuarios.Dock = DockStyle.Fill;
                pnl_usuarios.BringToFront();
                DataTable dt = new DataTable();
                D_usuarios funcion = new D_usuarios();
                funcion.mostrar_usuarios(ref dt);
                foreach (DataRow row in dt.Rows)
                {
                    Label b = new Label();
                    Panel p1 = new Panel();
                    PictureBox i1 = new PictureBox();
                    b.Text = row["login"].ToString();
                    b.Name = row["id_usuario"].ToString();
                    b.Size = new Size(175, 25);
                    b.Font = new Font("Consolas", 12);
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.White;
                    b.Dock = DockStyle.Bottom;
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Cursor = Cursors.Hand;
                    p1.Size = new Size(155, 167);
                    p1.BorderStyle = BorderStyle.None;
                    p1.BackColor = Color.FromArgb(29,29,29);
                    i1.Size = new Size(175, 132);
                    i1.Dock = DockStyle.Top;
                    i1.BackgroundImage = null;
                    byte[] bi = (Byte[])row["icono"];
                    MemoryStream ms = new MemoryStream(bi);
                    i1.Image = Image.FromStream(ms);
                    i1.SizeMode = PictureBoxSizeMode.Zoom;
                    i1.Tag = row["login"].ToString();
                    i1.Cursor = Cursors.Hand;
                    p1.Controls.Add(b);
                    p1.Controls.Add(i1);
                    b.BringToFront();
                    flowLayoutPanel2.Controls.Add(p1);

                    b.Click += new EventHandler(miEventoLabel);
                    i1.Click += miEnevtoImagen;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.StackTrace);
            }
        }

        private void miEnevtoImagen(object sender, EventArgs e)
        {
            usuario = ((PictureBox)sender).Tag.ToString();
            mostrarPanelPass();
        }

        private void miEventoLabel(object sender, EventArgs e)
        {
            usuario  = ((Label)sender).Text;
            mostrarPanelPass();
        }
        private void mostrarPanelPass()
        {
            pnl_ingreso_password.Visible = true;
            pnl_ingreso_password.Location = new Point((Width -pnl_ingreso_password.Width)/2,( Height - pnl_ingreso_password.Height)/2);
            pnl_usuarios.Visible = false;
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            validarUsuarios();
        }
        private void validarUsuarios()
        {
            L_usuarios parametros = new L_usuarios();
            D_usuarios funcion = new D_usuarios();
            parametros.password = txt_contraseña.Text;
            parametros.login = usuario;
            funcion.validarUsuario(parametros, ref id_usuario);
            if (id_usuario > 0)
            {
                Dispose();
                MenuPrincipal frm = new MenuPrincipal();
                frm.ShowDialog();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text += "0";
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_contraseña.Clear();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            int contador;
            contador = txt_contraseña.Text.Count();
            if (contador > 0)
            {
                txt_contraseña.Text = txt_contraseña.Text.Substring(0, txt_contraseña.Text.Count()-1);
            }
        }
    }
}
