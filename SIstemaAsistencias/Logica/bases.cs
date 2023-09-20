using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaAsistencias.Logica
{
    public class bases
    {
        public static void diseñoDgv(ref DataGridView listado )
        {
            listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listado.BackgroundColor = Color.Red;
            
        }
    }
}
