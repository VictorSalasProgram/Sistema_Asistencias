using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIstemaAsistencias.Logica;
using SIstemaAsistencias.Datos;


namespace SIstemaAsistencias.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }
        int idcargo;
        #region "MIS METODOS"
        private void limpiarTexto()
        {
            txt_nombres.Clear();
            txt_identificacion.Clear();
            txt_cargo.Clear();
            txt_sueldo_hora.Clear();
            buscar_cargos();

        }
        private void insertar_personal()
        {
            L_personal parametros = new L_personal();
            D_Personal funcion = new D_Personal();
            parametros.nombres = txt_nombres.Text;
            parametros.identificacion = txt_identificacion.Text;
            parametros.pais = cmb_pais.Text;
            
        }
        private void insertar_cargos()
        {
            if (!string.IsNullOrEmpty(txt_cargoG.Text))
            {
                if (!string.IsNullOrEmpty(txt_sueldoG.Text))
                {
                    L_cargos parametros = new L_cargos();
                    D_cargos funcion = new D_cargos();
                    parametros.cargo = txt_cargoG.Text;
                    parametros.sueldoPorHora = Convert.ToDouble(txt_sueldoG.Text);
                    if (funcion.usp_insertar_cargo(parametros) == true)
                    {
                        txt_cargo.Clear();
                        buscar_cargos();
                        pnl_cargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agregue el sueldo", "Falta el sueldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Agregue el cargo", "Falta el cargo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         

        }
        private void buscar_cargos()
        {
            DataTable dt = new DataTable();
            D_cargos funcion = new D_cargos();
            funcion.usp_buscar_cargo(ref dt, txt_cargo.Text);
            dgv_listado_cargos.DataSource = dt;
            bases.diseñoDgv( ref dgv_listado_cargos);
            dgv_listado_cargos.Columns[1].Visible = false;
            dgv_listado_cargos.Columns[3].Visible = false;
            dgv_listado_cargos.Visible = true;

        }
        #endregion

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            localizarDtvCargos();
            pnl_cargos.Visible = false;
            pnl_paginado.Visible = false;
            pnl_registros.Visible = true;
            pnl_registros.Dock = DockStyle.Fill;
            btn_guardar_personal.Visible = true;
            btn_guardar_cambios_personal.Visible = false;
            limpiarTexto();
            

        }

        private void btn_guardar_personal_Click(object sender, EventArgs e)
        {

        }

        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {
            buscar_cargos();
        }

        private void btn_agregar_cargo_Click(object sender, EventArgs e)
        {
            
            pnl_cargos.Visible = true;
            pnl_cargos.Dock = DockStyle.Fill;
            pnl_cargos.BringToFront();
            btn_guardarcambios.Visible = false;
            btn_guardarcambiosC.Visible = true;
            txt_cargoG.Clear();
            txt_sueldoG.Clear();
        }

        private void btn_guardarcambiosC_Click(object sender, EventArgs e)
        {
            editarCargos();
        }
        private void localizarDtvCargos()
        {
            dgv_listado_cargos.Location = new Point(txt_sueldo_hora.Location.X, txt_sueldo_hora.Location.Y);
            dgv_listado_cargos.Size = new Size(500,150);
            dgv_listado_cargos.Visible = true;
            lbl_sueldo.Visible = false;
            pnl_btn_guardar.Visible = false;
        }

        private void txt_sueldoG_KeyPress(object sender, KeyPressEventArgs e)
        {
            bases.Decimales(txt_sueldoG, e);
        }

        private void txt_sueldo_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            bases.Decimales(txt_sueldo_hora, e);
        }

        private void dgv_listado_cargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_listado_cargos.Columns["EditarC"].Index)
            {
                obtenerCargosEditar();
            }
            if (e.ColumnIndex == dgv_listado_cargos.Columns["Cargo"].Index)
            {
                obtenerDatosCargo();
            }
        }
        private void obtenerDatosCargo()
        {
            idcargo = Convert.ToInt32(dgv_listado_cargos.SelectedCells[1].Value);
            txt_cargo.Text = dgv_listado_cargos.SelectedCells[2].Value.ToString();
            txt_sueldo_hora.Text = dgv_listado_cargos.SelectedCells[3].Value.ToString();
            dgv_listado_cargos.Visible = false;
            pnl_btn_guardar.Visible = true;
            lbl_sueldo.Visible = true;

        }
        private void obtenerCargosEditar()
        {
            idcargo = Convert.ToInt32( dgv_listado_cargos.SelectedCells[1].Value);
            txt_cargoG.Text = dgv_listado_cargos.SelectedCells[2].Value.ToString();
            txt_sueldoG.Text = dgv_listado_cargos.SelectedCells[3].Value.ToString();
            btn_guardarcambios.Visible = false;
            btn_guardarcambiosC.Visible = true;
            txt_cargoG.Focus();
            txt_cargoG.SelectAll();
            pnl_cargos.Visible = true;
            pnl_cargos.Dock= DockStyle.Fill;
            pnl_cargos.BringToFront();
        }

        private void btn_volverCargos_Click(object sender, EventArgs e)
        {
            pnl_cargos.Visible = false;
        }

        private void btn_volverPersonal_Click(object sender, EventArgs e)
        {
            pnl_registros.Visible = false;
        }

        private void btn_guardarcambios_Click(object sender, EventArgs e)
        {
            insertar_cargos();
        }
        private void editarCargos()
        {
            L_cargos parametros = new L_cargos();
            D_cargos funcion = new D_cargos();
            parametros.id_cargo = idcargo;
            parametros.cargo = txt_cargoG.Text;
            parametros.sueldoPorHora = Convert.ToDouble(txt_sueldoG.Text);
            if (funcion.usp_editar_cargo(parametros) == true)
            {
                txt_cargo.Clear();
                buscar_cargos();
                pnl_cargos.Visible = false;
            }

        }
    }
}
