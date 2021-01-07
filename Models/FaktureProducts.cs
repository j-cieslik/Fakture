namespace Models
{
    public class FaktureProducts : BaseEntity 
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public float Tax { get; set; }

    }
}