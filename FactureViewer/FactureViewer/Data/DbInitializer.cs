using System;
using System.Linq;
using FactureViewer.Models;

namespace FactureViewer.Data
{
    public class DbInitializer
    {
        public static void Initialize(FactureContext context)
				{
						context.Database.EnsureCreated();

						if (context.Products.Any())
						{
							return;
						}


						var statuses = new Status[]
						{
							new Status{StatusName="Nowa"},
							new Status{StatusName="DoZatwierdzenia"},
							new Status{StatusName="Zatwierdzona"},
							new Status{StatusName="Anulowana"}
						};

						foreach (Status s in statuses)
						{
							context.Statuses.Add(s);
						}

						context.SaveChanges();

						var factures = new Facture[]
						{
							new Facture{Code=304, Date=DateTime.Parse("2005-09-01"), City="Krakow", StatusID=4},
							new Facture{Code=520, Date=DateTime.Parse("2015-04-01"), City="Warszawa", StatusID=1},
							new Facture{Code=301, Date=DateTime.Parse("2018-09-21"), City="Krakow", StatusID=2},
							new Facture{Code=350, Date=DateTime.Parse("2018-06-01"), City="Gdansk", StatusID=4},
							new Facture{Code=730, Date=DateTime.Parse("2015-10-01"), City="Katowice", StatusID=1},
							new Facture{Code=230, Date=DateTime.Parse("2020-09-01"), City="Poznan", StatusID=3}
						};

						foreach	(Facture f in factures)
						{
							context.Factures.Add(f);
						}

						context.SaveChanges();

						var products = new Product[]
						{
							new Product{Id=factures[0].Id ,WareName="Narty", Count=2, Price=500, Tax=15},
							new Product{Id=factures[1].Id ,WareName="Deska", Count=5, Price=100, Tax=17},
							new Product{Id=factures[2].Id ,WareName="Czapka", Count=7, Price=100, Tax=19},
							new Product{Id=factures[3].Id ,WareName="Kurtka", Count=1, Price=300, Tax=20},
							new Product{Id=factures[4].Id ,WareName="Spodnie", Count=2, Price=200, Tax=13},
							new Product{Id=factures[5].Id ,WareName="Lyzwy", Count=5, Price=10, Tax=11}
						};

						foreach (Product s in products)
						{
							context.Products.Add(s);
						}
						context.SaveChanges();

					
				}
    }
}