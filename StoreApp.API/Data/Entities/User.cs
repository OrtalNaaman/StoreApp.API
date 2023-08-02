using Microsoft.AspNetCore.Identity;
using StoreApp.API.Enums;

namespace StoreApp.API.Data.Entities
{
    public class User : IdentityUser
    {
        // Id + Name + Email  : IdentityUser שדות הקיימים במחלקת  
        public AuthLevel AuthLevel { get; set; }


    }
}
