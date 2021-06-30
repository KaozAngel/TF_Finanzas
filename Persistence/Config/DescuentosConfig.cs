using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TF_FinanzasBackEnd.Model;

namespace TF_FinanzasBackEnd.Persistence.Config
{
    public class DescuentosConfig
    {

        public DescuentosConfig(EntityTypeBuilder<Descuento> entityBuilder)
   
        {
            entityBuilder.HasKey(x => new
            {
                x.CodDescuento,
                x.RucUsuario

            });

            entityBuilder.HasOne(x => x.Usuario)
            .WithMany(x => x.CarteraDescuentos)
            .HasForeignKey(x => x.RucUsuario);
        }
    }
}
