using Models;

namespace Dtos
{
    public class FactureToCreateDto
    {
        public int Code { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public int FaktureProductsId { get; set; }
        public int FaktureStatusId { get; set; }
    }
}