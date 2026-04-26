using Microsoft.AspNetCore.Identity;

namespace WebSharingApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public DateTime joinDate { get; set; }
    }
}
