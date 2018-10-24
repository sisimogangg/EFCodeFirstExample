using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSample.Repository
{
    public interface IClientRepository
    {
        IEnumerable<Client> AllClients();
        long CancellClient(long clientID);
        Client Find(long? clientID);
    }
}
