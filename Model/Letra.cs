using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Model
{
    public class Letra
    {
        public string CodLetra { get; set; }
        public string RucUsuario { get; set; }
        public string TipoMoneda { get; set; }//1 soles 2 dolares 
        public int ValNominal { get; set; }
        public string Lugar { get; set; }
        public DateTime FechaGiro { get; set; }
        public DateTime FechaPago { get; set; }
        public List<Girador> Giradores { get; set; }
        public Usuario Usuario { get; set; }
        public bool Disponible { get; set; }




    }
}
