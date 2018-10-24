using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DATA.Models;
using EFCodeFirstSample.Repository;

namespace EFCodeFirstSample.Service
{
    public class ClientService : IClientService
    {
        /**
         * In A real world scenario this would actually handle some real world logic.
         * We don't really need it in this case
         */
        readonly IClientRepository repo;
        public ClientService(IClientRepository repo)
        {
            this.repo = repo;
        }

        public long DeleteClient(long clientID)
        {
           return repo.CancellClient(clientID);
        }

        public Client GetClient(long? clientID)
        {
            if(clientID == null)
            {
                return null;
            }
            return repo.Find(clientID);
        }

        public IEnumerable<Client> GetClients()
        {
            return repo.AllClients();
        }
    }
}