namespace WebApiBank.Models
{
    public class Base
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
        public string UpdatedBy { get; set;}
        public int IsActive { get; set; }
        public int IsDelete { get; set; }
    }
}
