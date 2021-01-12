using System;

namespace FactureViewer.ViewModel
{
    public class FactureViewModel
    {
        public int Code { get; set; }
				public DateTime Date { get; set; }
				public string City { get; set; }
				public int StatusID { get; set; }

				public string WareName { get; set; }
				public int Count { get; set; }
				public double Price { get; set; }
				public double Tax { get; set; }
    }
}