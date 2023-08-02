using StoreApp.API.Entities;

namespace StoreApp.API.Data.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public StoreItem? StoreItem { get; set; }
        public string? Size { get; set; }
        public int Quantity { get; set; }

    }
}
