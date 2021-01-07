using System;

namespace Models
{
    public class Fakture : BaseEntity 
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        //public FaktureProducts FaktureProducts { get; set; }
        public int FaktureProductsId { get; set; }
        //public FaktureStatus FaktureStatus { get; set; }
        public int FaktureStatusId { get; set; }
    }
}