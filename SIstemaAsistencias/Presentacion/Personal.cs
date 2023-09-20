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
        #region "MIS METODOS"
        private void limpiarTexto()
        {
            txt_nombres.Clear();
            txt_identificacion.Clear();
            txt_cargo.Clear();
            txt_sueldo_hora.Clear();

        }

        #endregion

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            pnl_cargos.Visible = false;
            pnl_paginado.Visible = false;
            pnl_registros.Visible = true;
            pnl_registros.Dock = DockStyle.Fill;
            btn_guardar_personal.Visible = true;
            btn_guardar_cambios_personal.Visible = false;
            limpiarTexto();

        }

    }
}
