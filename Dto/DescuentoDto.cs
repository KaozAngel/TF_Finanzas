using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Dto
{
    public class DescuentoDto
    {
        public string CodDescuento { get; set; }
        public string CodLetra { get; set; }
        public string RucUsuario { get; set; }
        public string TipoTasa { get; set; }
        public string Banco { get; set; }
        public DateTime FechaDescuento { get; set; }
        public int GastosIniciales { get; set; }
        public int GastosFinales { get; set; }
        public string Tasa { get; set; }
        public string Periodo { get; set; }
        public string Capitalizacion { get; set; }
        public float TCEA { get; set; }
        public float ValorRecibido { get; set; }
        public float ValorEntregado { get; set; }
        public float ValorNeto { get; set; }

    }

    public class DescuentoCreateDto
    {
        public string CodDescuento { get; set; }
        public string CodLetra { get; set; }
        public string RucUsuario { get; set; }
        public string TipoTasa { get; set; }
        public string Banco { get; set; }
        public DateTime FechaDescuento { get; set; }
 
        public int GastosIniciales { get; set; }
        public int GastosFinales { get; set; }
        public string Tasa { get; set; }
        public string Periodo { get; set; }
        public string Capitalizacion { get; set; }
        public float TCEA { get; set; }
        public float ValorRecibido { get; set; }
        public float ValorEntregado { get; set; }
        public float ValorNeto { get; set; }
        public UsuarioDto Usuario { get; set; }

    }
}
