using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_FinanzasBackEnd.Model.Identity
{
   
        public class ApplicationUserRole : IdentityUserRole<string>
        {
            public ApplicationUser User { get; set; }
            public ApplicationRole Role { get; set; }
        }
    
}
