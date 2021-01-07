using System.Collections.Generic;
using System.Threading.Tasks;
using Dtos;
using Models;

namespace Data
{
    public interface IFakturaRepo
    {
        Fakture GetFactureById(int id);
        IEnumerable<FactureToReturnDto> GetFactures();
        IEnumerable<FaktureProducts> GetFactureProducts();
        IEnumerable<FaktureStatus> GetFactureStatus();
        void CreateFacture(Fakture fct);
        void UpdateFacture(Fakture fct); 

        void DeleteFactureById(int id);
        
    }
}