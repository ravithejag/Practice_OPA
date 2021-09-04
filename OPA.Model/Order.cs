namespace OPA.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsDetailsRequired { get; set; }
    }
}
