﻿using System;
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
        int idcargo =0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int idpersonal;
        private int items_por_pagina = 10;
        string estado;
        int total_paginas;
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
            parametros.id_cargo = idcargo;
            parametros.sueldoPorHora = Convert.ToDouble(txt_sueldo_hora.Text);
            if (funcion.usp_insertar_personal(parametros) == true)
            {
                pnl_registros.Visible = false;
                mostrarPersonal();
            }
            
        }
        private void mostrarPersonal()
        {
            DataTable dt = new DataTable();
            D_Personal funcion = new D_Personal();
            funcion.usp_mostrar_personal(ref dt,desde,hasta);
            dgv_personal.DataSource = dt;
            diseñarDgvPersonal();


        }
        private void diseñarDgvPersonal()
        {
            bases.diseñoDgv(ref dgv_personal);
            pnl_paginado.Visible = true;
            dgv_personal.Columns[2].Visible = false;
            dgv_personal.Columns[7].Visible = false;
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
            if (!string.IsNullOrEmpty(txt_nombres.Text))
            {
                if (!string.IsNullOrEmpty(txt_identificacion.Text))
                {
                    if (!string.IsNullOrEmpty(cmb_pais.Text))
                    {
                        if(idcargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txt_sueldo_hora.Text))
                            {
                                insertar_personal();
                            }
                        }
                    }


                }
            }
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

        private void Personal_Load(object sender, EventArgs e)
        {
            mostrarPersonal();
        }

        private void dgv_personal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgv_personal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el registro?","Aviso del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    eliminarPersonal();
                }
                
            }
            if (e.ColumnIndex == this.dgv_personal.Columns["Editar"].Index)
            {
                obtenerDatos();
            }
        }
        private void obtenerDatos()
        {
            idpersonal = Convert.ToInt32(dgv_personal.SelectedCells[2].Value);
            estado = dgv_personal.SelectedCells[8].Value.ToString();
            if (estado == "ELIMINADO")
            {
                restaurarPersona();
            }
            else
            {
                txt_nombres.Text = dgv_personal.SelectedCells[3].Value.ToString();
                txt_identificacion.Text = dgv_personal.SelectedCells[4].Value.ToString();
                cmb_pais.Text = dgv_personal.SelectedCells[10].Value.ToString();
                txt_cargo.Text = dgv_personal.SelectedCells[6].Value.ToString();
                idcargo = Convert.ToInt32( dgv_personal.SelectedCells[7].Value);
                txt_sueldo_hora.Text = dgv_personal.SelectedCells[5].Value.ToString();
                pnl_paginado.Visible = false;
                pnl_registros.Visible = true;
                pnl_registros.Dock = DockStyle.Fill;
                dgv_listado_cargos.Visible = false;
                lbl_sueldo.Visible = true;
                pnl_btn_guardar.Visible = true;
                btn_guardar_personal.Visible = false;
                btn_guardar_cambios_personal.Visible = true;
                pnl_cargos.Visible = false;

            }

        }
        private void restaurarPersona()
        {

        }
        private void eliminarPersonal()
        {
            idpersonal = Convert.ToInt32(dgv_personal.SelectedCells[2].Value);
            L_personal parametros = new L_personal();
            D_Personal funcion = new D_Personal();
            parametros.id_personal = idpersonal;
            if (funcion.usp_eliminar_personal(parametros) == true)
            {
                mostrarPersonal();
            }
        }
    }
}
