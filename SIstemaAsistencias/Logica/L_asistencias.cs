using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaAsistencias.Logica
{
    public class L_asistencias
    {
        public int id_asistencias { get; set; }
        public int id_personal {  get; set; }   
        public DateTime fecha_entrada { get; set; } 
        public DateTime fecha_salida { get; set; }
        public string estado { get; set; }  
        public double horas {  get; set; }  
        public string observacion { get; set; } 
    }
}
