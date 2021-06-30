using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Model
{
    public class Descuento
    {       
        public string CodDescuento { get; set; }
        public string CodLetra { get; set; }
        public string RucUsuario { get; set; }
        public string TipoTasa { get; set; }
        public string Banco { get; set; }
        public DateTime FechaDescuento { get; set; }
        /*DateTime oldDate = new DateTime(2002,7,15);
        DateTime newDate = DateTime.Now;
        // Difference in days, hours, and minutes.
        TimeSpan ts = newDate - oldDate;
        // Difference in days.
        int differenceInDays = ts.Days;*/
        public int GastosIniciales { get; set; }
        public int GastosFinales { get; set; }
        public string Tasa { get; set; }
        public string Periodo { get; set; }
        public string Capitalizacion { get; set; }
        public float TCEA { get; set; }
        public float ValorRecibido { get; set; }
        public float ValorEntregado { get; set; }
        public float ValorNeto { get; set; }
        public Usuario Usuario { get; set; }

    }
}
