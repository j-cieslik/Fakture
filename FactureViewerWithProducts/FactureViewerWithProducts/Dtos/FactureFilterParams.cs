namespace FactureViewerWithProducts.Dtos
{
    public class FactureFilterParams
    {
        public string Code { get; set; }
				public string Date { get; set; }
				public string City { get; set; }
				public string Status { get; set; }
				public string sortOrder { get; set; }
    }
}