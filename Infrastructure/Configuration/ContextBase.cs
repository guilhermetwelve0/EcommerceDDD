using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=LAPTOP-65P1PT7M\\SQLEXPRESS;Initial Catalog=DDD_ECOMMERCE;Integrated Security=False;User ID=sa;Password=112233;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }


    }
}
