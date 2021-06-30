using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Model
{
    public class Girador
    {
        [Required]
        public string CodGiradores { get; set; }

        [Required]
        public string NombreGiradores { get; set; }
        public string DocumentoGiradores { get; set; }
        public string TelefonoGiradores { get; set; }
        public string DirecciónGiradores { get; set; }
        public byte FirmaGiradores { get; set; }        

        public int función { get; set; }//1 girador 2 girado
        public string CodLetra { get; set; }
        public Letra Letras { get; set; }

       

    }
}
