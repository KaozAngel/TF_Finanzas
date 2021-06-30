using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Dto
{


    public class LetraDto
    {
        public string CodLetra { get; set; }
        public string RucUsuario { get; set; }
        public string TipoMoneda { get; set; }
        public int ValNominal { get; set; }
        public string Lugar { get; set; }
        public DateTime FechaGiro { get; set; }
        public DateTime FechaPago { get; set; }
        public List<GiradorDto> Giradores { get; set; }
        public UsuarioDto Usuario { get; set; }
        public bool Disponible { get; set; }
    }
}
