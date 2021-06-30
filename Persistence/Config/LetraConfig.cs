using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TF_FinanzasBackEnd.Model;

namespace TF_FinanzasBackEnd.Persistence.Config
{
    public class LetraConfig
    {
        public LetraConfig(EntityTypeBuilder<Letra> entityBuilder)
        {
            entityBuilder.HasKey(x => new
            {
                x.CodLetra, 
                x.RucUsuario
            
            });

            entityBuilder.HasOne(x => x.Usuario)
            .WithMany(x => x.CarteraLetras)
            .HasForeignKey(x => x.RucUsuario);
        }
    }
}
