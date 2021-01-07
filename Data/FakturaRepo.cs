using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Dtos;
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
    public void CreateFacture(Fakture fct)
    {
      throw new NotImplementedException();
    }

    public void DeleteFactureById(int id)
    {
      throw new NotImplementedException();
    }

    public Task<Fakture> GetFactureByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<List<FaktureProducts>> GetFactureProductsAsync()
    {
      throw new NotImplementedException();
    }

    public Task<List<FactureToReturnDto>> GetFacturesAsync()
    {
      throw new NotImplementedException();
    }

    public Task<List<FaktureStatus>> GetFactureStatusAsync()
    {
      throw new NotImplementedException();
    }

    public void UpdateFacture(Fakture fct)
    {
      throw new NotImplementedException();
    }
  }
}