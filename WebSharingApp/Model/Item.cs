using System.ComponentModel;

namespace WebSharingApp.Model
{
    public class Item
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string condition { get; set; }
        public string image { get; set; }
        public DateTime DatePosted { get; set; }

        public string ownerId { get; set; }
        public ApplicationUser owner { get; set; }
    }
}