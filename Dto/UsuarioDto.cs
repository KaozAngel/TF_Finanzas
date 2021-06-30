using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Dto
{




    public class UsuarioDto
    {

        public string RucUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }
    public class UsuarioCreateDto
    {
        public string RucUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public List<LetraDto> CarteraLetras { get; set; }
        public List<DescuentoDto> CarteraDescuentos { get; set; }
    }
}
