using System;

namespace FactureViewer.ViewModel
{
    public class FactureViewDetails
    {
				public int Id {get; set; }
				public int Code { get; set; }
				public DateTime Date { get; set; }
				public string City { get; set; }
				public string StatusName { get; set; }

				public string WareName { get; set; }
				public int Count { get; set; }
				public double Price { get; set; }
				public string Tax { get; set; }

				public double PriceNetto {get; set; }
				public double PriceBrutto { get; set; }
    }
}