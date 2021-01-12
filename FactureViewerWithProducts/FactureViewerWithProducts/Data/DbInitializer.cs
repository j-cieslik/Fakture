using System;
using System.Linq;
using FactureViewerWithProducts.Data;
using FactureViewerWithProducts.Models;

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
							new Product{WareName="Narty", Count=2, Price=500, Tax=0.15},
							new Product{WareName="Deska", Count=5, Price=100, Tax=0.17},
							new Product{WareName="Czapka", Count=7, Price=100, Tax=0.19},
							new Product{WareName="Kurtka", Count=1, Price=300, Tax=0.20},
							new Product{WareName="Spodnie", Count=2, Price=200, Tax=0.13},
							new Product{WareName="Lyzwy", Count=5, Price=10, Tax=0.11}
						};

						foreach (Product s in products)
						{
							context.Products.Add(s);
						}
						context.SaveChanges();

						var factureproducts = new FactureProducts[]
						{
							new FactureProducts{FactureId=1, ProductId=1},
							new FactureProducts{FactureId=1, ProductId=2},
							new FactureProducts{FactureId=1, ProductId=3},
							new FactureProducts{FactureId=2, ProductId=1},
							new FactureProducts{FactureId=2, ProductId=3},
							new FactureProducts{FactureId=2, ProductId=5},
							new FactureProducts{FactureId=3, ProductId=2},
							new FactureProducts{FactureId=3, ProductId=3},
							new FactureProducts{FactureId=3, ProductId=5},
							new FactureProducts{FactureId=4, ProductId=1},
							new FactureProducts{FactureId=4, ProductId=2},
							new FactureProducts{FactureId=4, ProductId=4},
							new FactureProducts{FactureId=5, ProductId=1},
							new FactureProducts{FactureId=5, ProductId=2},
							new FactureProducts{FactureId=5, ProductId=6},
							new FactureProducts{FactureId=6, ProductId=1},
							new FactureProducts{FactureId=6, ProductId=4},
							new FactureProducts{FactureId=6, ProductId=3},
							new FactureProducts{FactureId=6, ProductId=6}
						};

						foreach (FactureProducts s in factureproducts)
						{
							context.FactureProducts.Add(s);
						}
						context.SaveChanges();
				}
    }
}