using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IgnisMercado.Areas.Identity.Data;

[assembly: HostingStartup(typeof(IgnisMercado.Areas.Identity.IdentityHostingStartup))]
namespace IgnisMercado.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<RazorPagesUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<IgnisMercadoIdentityDbContext>();
            });
        }
    }
}