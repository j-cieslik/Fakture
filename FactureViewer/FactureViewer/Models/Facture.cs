using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactureViewer.Models
{
    public class Facture
    {
				[ForeignKey("Product")]
        public int Id { get; set; }
				public int Code { get; set; }
				public DateTime Date { get; set; }
				public string City { get; set; }
				public int StatusID { get; set; }
				public Status Status { get; set; }
				public Product Product { get; set; }
				public int ProductID {get; set; }
    }
}