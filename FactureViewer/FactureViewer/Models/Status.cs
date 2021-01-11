using System.ComponentModel.DataAnnotations.Schema;

namespace FactureViewer.Models
{
    public class Status
    {
        public int Id { get; set; }
				public string StatusName { get; set; }
    }
}