using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Areas.Identity.Data;

namespace IgnisMercado.Areas.Identity.Data
{
    public class IgnisMercadoIdentityDbContext : IdentityDbContext<RazorPagesUser>
    {
        public IgnisMercadoIdentityDbContext(DbContextOptions<IgnisMercadoIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
