using System.Collections.Generic;
using System.Threading.Tasks;
using Dtos;
using Models;

namespace Data
{
    public interface IFakturaRepo
    {
        Task<Fakture> GetFactureByIdAsync(int id);
        Task<List<Fakture>> GetFacturesAsync();
        Task<List<FaktureProducts>> GetFactureProductsAsync();
        Task<List<FaktureStatus>> GetFactureStatusAsync();
        void CreateFacture(FactureToCreateDto fct);
        void UpdateFacture(Fakture fct); 
        void DeleteFacture(Fakture fct);
        bool SaveChanges();
    }
}