using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public interface IFakturaRepo
    {
        Fakture GetFactureById(int id);
        IEnumerable<Fakture> GetFactures();
        IEnumerable<FaktureProducts> GetFactureProducts();
        IEnumerable<FaktureStatus> GetFactureStatus();
        
    }
}