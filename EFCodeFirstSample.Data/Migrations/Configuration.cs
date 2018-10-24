namespace DATA.Migrations
{
    using DATA.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DATA.ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DATA.ClientContext context)
        {
            var clients = new List<Client>
            {
               new Client { Name= "Godfrey", Surname= "Sisimogang", Gender= "Male", EmailAddress = "Godfrey@domain.co.za", ContactNumber = "0826955324", Cancelled = false  },
               new Client { Name= "Sarah", Surname= "Stolz", Gender= "Female", EmailAddress = "Sarah@stolz.co.za", ContactNumber = "0623456877", Cancelled = false  },
               new Client{ Name= "Brian", Surname= "Johnson", Gender= "Male", EmailAddress = "Brian@Johnson.co.za", ContactNumber = "03158007834", Cancelled = false  }
            };

            clients.ForEach(c => context.Clients.AddOrUpdate(p => p.EmailAddress, c));


            /*foreach(Client c in clients)
            {
                var existingClient = context.Clients.Where(e => e.Name == c.Name && e.Surname == c.Surname);
                if (existingClient == null)
                {
                    context.Clients.Add(c);
                }
            } */

            context.SaveChanges();
        }
    }
}
