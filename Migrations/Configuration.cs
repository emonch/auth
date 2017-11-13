namespace AuthExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AuthExample.Entities;
    using System.Collections.Generic;
    using AuthExample.API;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthExample.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            // register mysql code generator
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());

            SetHistoryContextFactory("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));

        }

        protected override void Seed(AuthExample.AuthContext context)
        {
            if (context.Clients.Count() > 0)
            {
                return;
            }

            context.Clients.AddRange(BuildClientList());
            context.SaveChanges();
        }

        private static List<Client> BuildClientList()
        {
            List<Client> clientList = new List<Client>
            {
                new Client
                {
                    Id = "ngAuthApp",
                    Secret= Helper.GetHash("abc@123"),
                    Name="AngularJS front-end Application",
                    ApplicationType =  Models.ApplicationTypes.JavaScript,
                    Active = true,
                    RefreshTokenLifeTime = 7200,
//                    AllowedOrigin = "http://ngauthenticationweb.azurewebsites.net"
                    AllowedOrigin = "*"
                },
                new Client
                { Id = "consoleApp",
                    Secret=Helper.GetHash("123@abc"),
                    Name="Console Application",
                    ApplicationType =Models.ApplicationTypes.NativeConfidential,
                    Active = true,
                    RefreshTokenLifeTime = 14400,
                    AllowedOrigin = "*"
                }
            };

            return clientList;
        }
    }
}
