using StoreApp.API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.API.Entities
{
    public class StoreItem
    {
        public Category Category { get; set; }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }

        [NotMapped]
        public string[]? Sizes { get; set; }
    }
}