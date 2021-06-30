using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TF_FinanzasBackEnd.Model;


namespace TF_FinanzasBackEnd.Persistence.Config
{
    public class GiradoresConfig
    {
        public GiradoresConfig(EntityTypeBuilder<Girador> entityBuilder)
        {
            
                entityBuilder.HasKey(x => new
                {
                    x.CodGiradores,
                    x.CodLetra
                   
                });

                entityBuilder.HasOne(x => x.Letras)
                .WithMany(x => x.Giradores)
                .HasForeignKey(x => x.CodLetra);
            }
        
    }
}
