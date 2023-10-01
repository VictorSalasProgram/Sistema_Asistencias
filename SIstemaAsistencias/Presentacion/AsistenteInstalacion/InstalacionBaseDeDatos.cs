using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Presentacion.AsistenteInstalacion
{
    public partial class InstalacionBaseDeDatos : Form
    {
        public InstalacionBaseDeDatos()
        {
            InitializeComponent();
        }
        string nombre_del_usuario;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InstalacionBaseDeDatos_Load(object sender, EventArgs e)
        {
           
        }
        private void centrarPaneles()
        {
            panel2.Location = new Point((Width - panel2.Width) / 2, (Height - panel2.Height) / 2);
            nombre_del_usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Cursor = Cursors.WaitCursor;
            panel3.Visible = false;
            panel3.Dock = DockStyle.None;
        }
    }
}
