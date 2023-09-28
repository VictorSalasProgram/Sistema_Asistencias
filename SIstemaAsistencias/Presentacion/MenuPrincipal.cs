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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            pnl_bienvenida.Dock = DockStyle.Fill;
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            pnl_padre.Controls.Clear();
            Personal control = new Personal();
            control.Dock = DockStyle.Fill;
            pnl_padre.Controls.Add(control);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            pnl_padre.Controls.Clear();
            Ctr_usuarios control = new Ctr_usuarios();
            control.Dock = DockStyle.Fill;
            pnl_padre.Controls.Add(control);
        }
    }
}
