using DATA;
using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSample.Service
{
    public interface IClientService
    {
        IEnumerable<Client> GetClients();
        long DeleteClient(long clientID);
        Client GetClient(long? clientID);
    }
}
