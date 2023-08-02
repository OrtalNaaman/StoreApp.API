using StoreApp.API.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.API.Data.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int StoreItemId { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Sent { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
