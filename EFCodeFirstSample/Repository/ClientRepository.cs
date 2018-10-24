using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DATA.Models;

namespace EFCodeFirstSample.Repository
{
    public class ClientRepository : IClientRepository
    {
        readonly ClientContext db;
        public ClientRepository(ClientContext db)
        {
            this.db = db;
        }
        public IEnumerable<Client> AllClients()
        {
            return db.Clients.Where(c => (!c.Cancelled));
        }

        public long CancellClient(long clientID)
        {
            var c = db.Clients.Where(p => p.ClientID == clientID).SingleOrDefault();
            c.Cancelled = true;
            db.SaveChanges();
            return c.ClientID;
        }

        public Client Find(long? clientID)
        {
            return db.Clients.Find(clientID);
        }
    }
}