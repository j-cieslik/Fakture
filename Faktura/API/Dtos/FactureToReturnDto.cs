using System;
using Models;

namespace Dtos
{
    public class FactureToReturnDto
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public FaktureProducts FaktureProducts { get; set; }
        public string Name { get; set; }
    }
}