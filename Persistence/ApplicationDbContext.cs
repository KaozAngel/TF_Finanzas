using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TF_FinanzasBackEnd.Model;
using TF_FinanzasBackEnd.Model.Identity;
using TF_FinanzasBackEnd.Persistence.Config;


namespace TF_FinanzasBackEnd.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
        IdentityUserClaim<string>,
        ApplicationUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Descuento> Descuentos { get; set; }
        public DbSet<Girador> Giradores { get; set; }
        public DbSet<Letra> Letras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new DescuentosConfig(builder.Entity<Descuento>());
            new GiradoresConfig(builder.Entity<Girador>());
            new LetraConfig(builder.Entity<Letra>());
            new UsuarioConfig(builder.Entity<Usuario>());
        }

    } 
}

























