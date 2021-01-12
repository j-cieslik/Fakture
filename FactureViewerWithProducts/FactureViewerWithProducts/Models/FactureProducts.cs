using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactureViewerWithProducts.Models
{
    public class FactureProducts
    {
        public int FactureId { get; set; }
				public int ProductId { get; set; }

				public Facture Facture {get; set; }
				public Product Product {get; set; }
    }
}