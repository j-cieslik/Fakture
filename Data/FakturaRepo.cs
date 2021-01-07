using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dtos;
using Models;

namespace Data
{
  public class FakturaRepo : IFakturaRepo
  {

    private List<FaktureStatus> _status = new List<FaktureStatus>();
    private List<FaktureProducts> _products = new List<FaktureProducts>();
    private List<Fakture> _factures = new List<Fakture>();

    
    public FakturaRepo()
    {
      CreateFactures();
    }

    public Fakture GetFactureById(int id)
    {
      var facture = _factures.Find(x => x.Id == id);

      return facture;
    }

    public IEnumerable<FaktureStatus> GetFactureStatus()
    {
      _status.Add(new FaktureStatus{Id=1, Name="DoZatwierdzenia"});
      _status.Add(new FaktureStatus{Id=2, Name="Zatwierdzona"});
      _status.Add(new FaktureStatus{Id=3, Name="Anulowana"});
      _status.Add(new FaktureStatus{Id=4, Name="Nowa"});

      return _status;
    }

    public IEnumerable<FaktureProducts> GetFactureProducts()
    {

      _products.Add(new FaktureProducts{Id=1, Name="Deska", Count=5, Price=200, Tax=0.17f});
      _products.Add(new FaktureProducts{Id=2, Name="Czapka", Count=7, Price=50, Tax=0.2f});
      _products.Add(new FaktureProducts{Id=3, Name="Kurtka", Count=1, Price=70, Tax=0.19f});
      _products.Add(new FaktureProducts{Id=4, Name="Spodnie", Count=2, Price=80, Tax=0.1f});


      return _products;
    }

    public IEnumerable<FactureToReturnDto> GetFactures()
    {
      var status = GetFactureStatus();
      var products = GetFactureProducts();

      var facture = _factures.Join(status,
        x => x.FaktureStatusId,
        y => y.Id,
        (factures, status) => new FactureToReturnDto
        {
          Id = factures.Id,
          Code = factures.Code,
          Date = factures.Date,
          City = factures.City,
          Name = status.Name,
          FaktureProductsId = factures.FaktureProductsId
        }
      ).ToList();

      return facture;
    }
    public void CreateFactures()
    {
      _factures.Add(new Fakture{Id=1, Code=40, Date=new DateTime(2020, 4, 1), City="Warszawa", FaktureProductsId=1, FaktureStatusId=2});
      _factures.Add(new Fakture{Id=2, Code=90, Date=new DateTime(2020, 12, 6), City="Gdansk", FaktureProductsId=4, FaktureStatusId=1});
      _factures.Add(new Fakture{Id=3, Code=90, Date=new DateTime(2020, 12, 6), City="Gdansk", FaktureProductsId=4, FaktureStatusId=1});
      _factures.Add(new Fakture{Id=4, Code=90, Date=new DateTime(2020, 12, 6), City="Gdansk", FaktureProductsId=4, FaktureStatusId=1});
      _factures.Add(new Fakture{Id=5, Code=90, Date=new DateTime(2020, 12, 6), City="Gdansk", FaktureProductsId=4, FaktureStatusId=1});
    }

    public void CreateFacture(Fakture fct)
    {
      _factures.Add(fct);
    }

    public void UpdateFacture(Fakture fct)
    {
      var index = fct.Id;

      _factures[index].City = fct.City;
      _factures[index].Code = fct.Code;
      _factures[index].Date = fct.Date;
      _factures[index].FaktureProductsId = fct.FaktureProductsId;
      _factures[index].FaktureStatusId = fct.FaktureStatusId;
    }

    public void DeleteFactureById(int id)
    {
      var itemToRemove = _factures.Find(x => x.Id == id);

      _factures.Remove(itemToRemove);
    }
  }
}