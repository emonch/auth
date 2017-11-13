using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using MySql.Data.Entity;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using AuthExample.Entities;

namespace AuthExample
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MySqlInitializer());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<ItemCarteira> ItensCarteira { get; set; }
    }
}