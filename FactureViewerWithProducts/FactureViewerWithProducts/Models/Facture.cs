using System;
using System.Collections.Generic;

namespace FactureViewerWithProducts.Models
{
    public class Facture
    {
        public int Id { get; set; }
				public int Code { get; set; }
				public DateTime Date { get; set; }
				public string City { get; set; }
				public int StatusID { get; set; }
				public Status Status { get; set; }

				public ICollection<FactureProducts> FactureProducts {get; set; }
    }
}