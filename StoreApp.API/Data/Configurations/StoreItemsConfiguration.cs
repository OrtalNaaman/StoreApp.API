using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreApp.API.Entities;
using StoreApp.API.Enums;

namespace StoreApp.API.Data.Configurations
{
    public class StoreItemsConfiguration : IEntityTypeConfiguration<StoreItem>
    {
        public void Configure(EntityTypeBuilder<StoreItem> builder)
        {
            builder.HasData(
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 1,
                    Title = "Baby Bridesmaid",
                    Image = "assets/Images/BabyBridesmaidWhiteDress.jpg",
                    Price = 70,
                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 2,
                    Title = "Baby Dots Dress",
                    Image = "assets/Images/BabyDotsDressBlueAndWhite.jpg",
                    Price = 54,
                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 3,
                    Title = "Black&White Baby Dress",
                    Image = "assets/Images/BabyDressBlackAndWhite.jpg",
                    Price = 57,
                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 4,
                    Title = "Little Flower Baby Girl Dress",
                    Image = "assets/Images/BabyFlowerGirlDressLightPink.jpg",
                    Price = 70,
                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 5,
                    Title = "Jeans Set",
                    Image = "assets/Images/BabyJeansSet.jpg",
                    Price = 50,
                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 6,
                    Title = "Baby Overall",
                    Image = "assets/Images/BabyPinkOverall.jpg",
                    Price = 56,
                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 7,
                    Title = "Baby Red Dress",
                    Image = "assets/Images/BabyRedDress.jpg",
                    Price = 60,

                },
                new StoreItem
                {
                    Category = Category.BABIES,
                    Id = 8,
                    Title = "Baby Yelow Flowers Dress",
                    Image = "assets/Images/BabyYelowFlowersDress.jpg",
                    Price = 63,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 9,
                    Title = "Girl Bridesmaid",
                    Image = "assets/Images/GirlBridesmaidWhiteDress.jpg",
                    Price = 85,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 10,
                    Title = "Brown&White Dress",
                    Image = "assets/Images/GirlsDressBrownAndWhite.jpg",
                    Price = 58,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 11,
                    Title = "Two Piece Black&White",
                    Image = "assets/Images/GirlsDressTwoPieceBlackAndWhite.jpg",
                    Price = 60,
                },

                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 12,
                    Title = "Two Piece White&Flowers",
                    Image = "assets/Images/GirlsDressTwoPieceWhiteAndFlowers.jpg",
                    Price = 53,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 13,
                    Title = "Two Piece White&Pink",
                    Image = "assets/Images/GirlsTwoPieceWhiteAndPink.jpg",
                    Price = 50,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 14,
                    Title = "Multi Color Dress",
                    Image = "assets/Images/GirlsMultiColorDressWhitePinkBlue.jpg",
                    Price = 48,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 15,
                    Title = "Overall",
                    Image = "assets/Images/GirlsPinkOverall.jpg",
                    Price = 52,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 16,
                    Title = "Girls Set Blue",
                    Image = "assets/Images/GirlsSetJeansAndWhite.jpg",
                    Price = 50,
                },
                new StoreItem
                {
                    Category = Category.GIRLS,
                    Id = 17,
                    Title = "Girls Set Light Blue",
                    Image = "assets/Images/GirlsSetLightBlueAndWhite.jpg",
                    Price = 50,
                }            
                );
        }
    }
}
