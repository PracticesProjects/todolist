using Microsoft.AspNetCore.Identity;

namespace MyNotes.Models
{
    public class User:IdentityUser
    {
        public String? FirstName { get; set; }
        
        public String? LastName { get; set; }
    }
}