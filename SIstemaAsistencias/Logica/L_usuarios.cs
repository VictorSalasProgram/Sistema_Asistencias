using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaAsistencias.Logica
{
    public class L_usuarios
    {
        public int id_usuario {  get; set; }
        public string nombres{ get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public byte[] icono { get; set; }
        public string estado { get; set; }

    }
}
