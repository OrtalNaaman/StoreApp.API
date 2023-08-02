using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreApp.API.Data.Entities;
using StoreApp.API.Enums;

namespace StoreApp.API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                 new User

                 {
                     Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     UserName = "Admin",
                     NormalizedUserName = "ADMIN",
                     Email = "admin@email.com",
                     NormalizedEmail = "ADMIN@EMAIL.COM",                
                     PasswordHash = hasher.HashPassword(null, "123!Qaz123"),
                     EmailConfirmed = true,
                     AuthLevel = AuthLevel.Admin,
                     SecurityStamp = Guid.NewGuid().ToString("D")
                 },

                 new User

                 {
                     Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                     UserName = "Neta",
                     NormalizedUserName = "NETA",
                     Email = "netush@gmail.com",
                     NormalizedEmail = "NETUSH@GMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "Neta@123"),
                     EmailConfirmed = true,
                     AuthLevel = AuthLevel.User,
                     SecurityStamp = Guid.NewGuid().ToString("D")
                 }

             );
        }
    }
}
