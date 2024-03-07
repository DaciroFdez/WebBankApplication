namespace WebApiBank.DTOs
{
    public class UserDTO
    {
        public string DocumentNumber { get; set; }
        public string NameUser { get; set; }
        public int DocumentTypeId { get; set; }
        public int UserTypeId { get; set; }
        public int SiteId { get; set; }
    }
}
