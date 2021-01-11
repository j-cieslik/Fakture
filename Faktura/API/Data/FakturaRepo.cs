using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Dtos;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
  public class FakturaRepo : IFakturaRepo
  {
    private readonly StoreContext _contex;

    public FakturaRepo(StoreContext contex)
    {
      _contex = contex;

    }
    public void CreateFacture(FactureToCreateDto fct)
    {
      if (fct == null)
      {
        throw new ArgumentException(nameof(fct));
      }

      var facture = new Fakture
      {
        Code = fct.Code,
        Date = fct.Date,
        City = fct.City,
        FaktureProductsId = fct.FaktureProductsId,
        FaktureStatusId = fct.FaktureStatusId,
      };

      _contex.Add(facture);
    }
    public void DeleteFacture(Fakture fct)
    {
      if (fct == null)
      {
        throw new ArgumentNullException(nameof(fct));
      }

      _contex.Fakture.Remove(fct);
    }

    public async Task<Fakture> GetFactureByIdAsync(int id)
    {
      return await _contex.Fakture
          .Include(p => p.FaktureProducts)
          .Include(p => p.FaktureStatus)
          .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<FaktureProducts>> GetFactureProductsAsync()
    {
      return await _contex.FaktureProducts.ToListAsync();
    }

    public async Task<List<Fakture>> GetFacturesAsync()
    {
      return await _contex.Fakture
          .Include(p => p.FaktureProducts)
          .Include(p => p.FaktureStatus)
          .ToListAsync();
    }

    public async Task<List<FaktureStatus>> GetFactureStatusAsync()
    {
      return await _contex.FaktureStatus.ToListAsync();
    }

    public bool SaveChanges()
    {
      return (_contex.SaveChanges() >= 0);
    }

    public void UpdateFacture(Fakture fct)
    {
      throw new NotImplementedException();
    }
  }
}