using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactureViewer.Models
{
    public class Product
    {
				[Key]
				[ForeignKey("Facture")]
        public int Id { get; set; }
				public string WareName { get; set; }
				public int Count { get; set; }
				public double Price { get; set; }
				public int Tax { get; set; }
				public Facture Facture { get; set; }
    }
}