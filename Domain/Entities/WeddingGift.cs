namespace Domain.Entities
{
    public class WeddingGift : Entity
    {
        public int WeddingId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsRegistred { get; set; }
        /// <summary>
        /// Registred to wedding guest with userID
        /// </summary>
        public int UserId { get; set; }
    }
}