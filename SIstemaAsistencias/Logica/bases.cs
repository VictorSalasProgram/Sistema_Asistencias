using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SIstemaAsistencias.Logica.bases;

namespace SIstemaAsistencias.Logica
{
    public class bases
    {
        public static void diseñoDgv(ref DataGridView listado )
        {
            listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listado.BackgroundColor = Color.FromArgb(29,29,29);
            listado.EnableHeadersVisualStyles = false;
            listado.BorderStyle = BorderStyle.None;
            listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            listado.RowHeadersVisible = false;

            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(29, 29, 29);
            cabecera.ForeColor = Color.WhiteSmoke;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            listado.ColumnHeadersDefaultCellStyle = cabecera;

        }
        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';  // Reemplazar la coma por un punto
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }
        public static void diseñoDgvEliminado(ref DataGridView listado)
        {
            foreach (DataGridViewRow row in listado.Rows)
            {
                string estado;
                estado = row.Cells["estado"].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Consolas",10,FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            

        }
        public enum DateInterval
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            //WeekOfYear,
            Year
        }

        public static long DateDiff(DateInterval intervalType, DateTime dateOne, DateTime dateTwo)
        {
            switch (intervalType)
            {
                case DateInterval.Day:
                case DateInterval.DayOfYear:
                    TimeSpan spanForDays = dateTwo - dateOne;
                    return (long)spanForDays.TotalDays;
                case DateInterval.Hour:
                    TimeSpan spanForHours = dateTwo - dateOne;
                    return (long)spanForHours.TotalHours;
                case DateInterval.Minute:
                    TimeSpan spanForMinutes = dateTwo - dateOne;
                    return (long)spanForMinutes.TotalMinutes;
                case DateInterval.Month:
                    TimeSpan spanForMonths = dateTwo - dateOne;
                    return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter -dateOneQuarter;
                case DateInterval.Second:
                    TimeSpan spanForSeconds = dateTwo - dateOne;
                    return (long)spanForSeconds.TotalSeconds;
                case DateInterval.Weekday:
                    TimeSpan spanForWeekdays = dateTwo - dateOne;
                    return (long)(spanForWeekdays.TotalDays / 7.0);
                //case DateInterval.WeekOfYear:
                //    DateTime  dateOneModified = dateOne;
                //    DateTime dateTwoModified = dateTwo;
                //    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.)


                case DateInterval.Year:
                    return  dateTwo.Year - dateOne.Year;
                default:
                    return 0;
            }
        }
    }
    
}
    
