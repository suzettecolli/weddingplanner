namespace Domain.Entities
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}
