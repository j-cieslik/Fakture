using System.Collections.Generic;

namespace FactureViewerWithProducts.Models
{
    public class Product
    {
        public int Id { get; set; }
				public string WareName { get; set; }
				public int Count { get; set; }
				public double Price { get; set; }
				public double Tax { get; set; }

				public ICollection<FactureProducts> FactureProducts {get; set; }
    }
}