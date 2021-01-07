using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Data
{
  public class FakturaRepo : IFakturaRepo
  {
    public Fakture GetFactureById(int id)
    {
      var facture = GetFactures().FirstOrDefault(x => x.Id == id);

      return facture;
    }

    public IEnumerable<FaktureStatus> GetFactureStatus()
    {
      var status = new List<FaktureStatus>
      {
          new FaktureStatus{Id=0, Name="Nowa"},
          new FaktureStatus{Id=1, Name="DoZatwierdzenia"},
          new FaktureStatus{Id=2, Name="Zatwierdzona"},
          new FaktureStatus{Id=3, Name="Anulowana"}
      };

      return status;
    }

    public IEnumerable<FaktureProducts> GetFactureProducts()
    {
      var products = new List<FaktureProducts>
      {
        new FaktureProducts{Id=0, Name="Narty", Count=2, Price=100, Tax=0.15f},
        new FaktureProducts{Id=1, Name="Deska", Count=5, Price=200, Tax=0.17f},
        new FaktureProducts{Id=2, Name="Czapka", Count=7, Price=50, Tax=0.2f},
        new FaktureProducts{Id=3, Name="Kurtka", Count=1, Price=70, Tax=0.19f},
        new FaktureProducts{Id=4, Name="Spodnie", Count=2, Price=80, Tax=0.1f}
      };

      return products;
    }

    public IEnumerable<Fakture> GetFactures()
    {
      var factures = new List<Fakture>
      {
        new Fakture{Id=0, Code=20, Date=new DateTime(2020, 3, 4), City="Krakow", FaktureProductsId=2, FaktureStatusId=5},
        new Fakture{Id=1, Code=40, Date=new DateTime(2020, 4, 1), City="Warszawa", FaktureProductsId=1, FaktureStatusId=2},
        new Fakture{Id=2, Code=90, Date=new DateTime(2020, 12, 6), City="Gdansk", FaktureProductsId=4, FaktureStatusId=1}
      };

      var status = GetFactureStatus();
      var products = GetFactureProducts();

      var facture = factures.Join(products,
        x => x.FaktureProductsId,
        y => y.Id,
        (factures, products) => new Fakture
          {
            Id = factures.Id,
            Code = factures.Code,
            Date = factures.Date,
            City = factures.City,
            FaktureStatusId = factures.FaktureStatusId,
            FaktureProductsId = factures.FaktureProductsId
          }
      ).Join(status,
        x => x.FaktureStatusId,
        y => y.Id,
        (factures, status) => new Fakture
          {
            Id = factures.Id,
            Code = factures.Code,
            Date = factures.Date,
            City = factures.City,
            FaktureStatusId = factures.FaktureStatusId,
            FaktureProductsId = factures.FaktureProductsId
          }
      ).ToList();

      return facture;
    }
  }
}