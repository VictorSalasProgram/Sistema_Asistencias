using SIstemaAsistencias.Datos;
using SIstemaAsistencias.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Presentacion
{
    public partial class Ctr_usuarios : UserControl
    {
        public Ctr_usuarios()
        {
            InitializeComponent();
        }
        int id_usuario;

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitarPaneles();
            mostrarModulos();
        }
        private void Limpiar()
        {
            txt_nombre.Clear();
            txt_contraseña.Clear();
            txt_usuario.Clear();
        }
        private void habilitarPaneles()
        {
            pnl_registro.Visible = true;
            lbl_anuncio_icono.Visible = true;
            pnl_icono.Visible = false;
            pnl_registro.Dock = DockStyle.Fill;
            pnl_registro.BringToFront();
            btn_guardar.Visible = true;
            btn_actualizar.Visible = false;
        }
        private void mostrarModulos()
        {
            D_modulos funcion = new D_modulos();
            DataTable dt = new DataTable();
            funcion.mostrarModulos(ref dt);
            dataListadoModulos.DataSource = dt;
            dataListadoModulos.Columns[1].Visible = false;
        }

      

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text))
            {
                if (!string.IsNullOrEmpty(txt_usuario.Text))
                {
                    if (!string.IsNullOrEmpty(txt_contraseña.Text))
                    {
                        if (lbl_anuncio_icono.Visible==false)
                        {
                            insertarUsuario();
                        }
                        else
                        {
                            MessageBox.Show("Elija un icono", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el usuario", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre","Aviso del sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void insertarUsuario()
        {
            L_usuarios parametros = new L_usuarios();
            D_usuarios funcion = new D_usuarios();
            parametros.nombres = txt_nombre.Text;
            parametros.login = txt_usuario.Text;
            parametros.password = txt_contraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.icono = ms.GetBuffer();
            if (funcion.insertar_usuarios(parametros)==true)
            {
                obtener_id_usuario();
                insertarPermisos();
            }

        }
        private void obtener_id_usuario()
        {
            D_usuarios funcion = new D_usuarios();
            funcion.obtener_id_usuario(ref id_usuario, txt_usuario.Text);
        }
        private void insertarPermisos()
        {
            foreach (DataGridViewRow row in dataListadoModulos.Rows) 
            {
                int id_modulo = Convert.ToInt32( row.Cells["id_modulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    L_permisos parametros = new L_permisos();
                    D_permisos funcion = new D_permisos();
                    parametros.id_modulo = id_modulo;
                    parametros.id_usuario = id_usuario;
                    funcion.insertar_permisos(parametros);
                    
                    
                }
            }
             mostrarUsuarios();
             pnl_registro.Visible = false;
        }
        private void mostrarUsuarios()
        {
            DataTable dt = new DataTable();
            D_usuarios funcion = new D_usuarios();
            funcion.mostrar_usuarios(ref dt);
            dgv_personal.DataSource = dt;
            diseñarDgvUsuarios();

        }
        private void diseñarDgvUsuarios()
        {
            bases.diseñoDgv(ref  dgv_personal);
            bases.diseñoDgvEliminado(ref dgv_personal);
            dgv_personal.Columns[2].Visible = false;
            dgv_personal.Columns[5].Visible = false;
            dgv_personal.Columns[6].Visible = false;

        }

        private void lbl_anuncio_icono_Click(object sender, EventArgs e)
        {
            mostrarPanelIconos();
        }
        private void mostrarPanelIconos()
        {
            pnl_icono.Visible = true;
            pnl_icono.Dock = DockStyle.Fill;
            pnl_icono.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox3.Image;
            ocultarPanelIcono();
        }
        private void ocultarPanelIcono()
        {
            pnl_icono.Visible = false;
            lbl_anuncio_icono.Visible = false;
            Icono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox4.Image;
            ocultarPanelIcono();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox5.Image;
            ocultarPanelIcono();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox6.Image;
            ocultarPanelIcono();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox7.Image;
            ocultarPanelIcono();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox9.Image;
            ocultarPanelIcono();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox8.Image;
            ocultarPanelIcono();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox10.Image;
            ocultarPanelIcono();
        }

        private void pic_agregar_icono_pc_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes |*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIcono();
            }
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            mostrarPanelIconos();
        }

        private void dgv_personal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ctr_usuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void dataListadoModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled= false;
            }
            else  
            {
                e.Handled= true;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            pnl_registro.Visible= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ocultarPanelIcono();
        }
    }
}
