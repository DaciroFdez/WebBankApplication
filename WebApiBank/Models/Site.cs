using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiBank.Models
{
    public class Site : Base
    {
        [Key]
        public int SiteId { get; set; }
        public string SiteName { get; set; }

        //[JsonIgnore]
        [InverseProperty("Users")]
        public virtual ICollection<User> Users { get; set; }
        //[JsonIgnore]
        [InverseProperty("Accounts")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
