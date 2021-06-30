using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Model
{
    public class Usuario
    {
        public string RucUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public List<Letra> CarteraLetras { get; set; }
        public List<Descuento> CarteraDescuentos { get; set;}

       // public List <Letras > HistorialLetras { get; set; }

    }
}
