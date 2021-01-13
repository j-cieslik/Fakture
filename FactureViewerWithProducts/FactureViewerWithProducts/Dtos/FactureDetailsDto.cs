using System;
using System.Collections;
using System.Collections.Generic;
using FactureViewerWithProducts.Models;

namespace FactureViewerWithProducts.Dtos
{
    public class FactureDetailsDto
    {
        public int Id {get; set; }
				public int Code { get; set; }
				public DateTime Date { get; set; }
				public string City { get; set; }
				public string StatusName { get; set; }

				public List<Product> Product {get; set; }
				public double PriceNetto {get; set; }
				public double PriceBrutto { get; set; }
    }
}