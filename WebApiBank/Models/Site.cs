using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class Site : Base
    {
        [Key]
        public int SiteId { get; set; }
        public string SiteName { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
