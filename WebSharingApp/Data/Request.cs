namespace WebSharingApp.Data
{
    public class Request
    {
        public int requestId { get; set; }
        public int itemId { get; set; }
        public string requesterId { get; set; }
        public string status { get; set; }
        public DateTime requestDate { get; set; }

        public Item item  { get; set; }
        public  ApplicationUser requester { get; set; }
    }
}
