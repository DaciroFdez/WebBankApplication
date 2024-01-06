using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBank.Models
{
    public class Account : Base
    {
        [Key] public int Id { get; set; }
        [ForeignKey("TypeAccount")] public int TypeAccountId { get; set; }
        public int NumberAccount {  get; set; }
        public int Amount { get; set; }
        [ForeignKey("Site")] public int SiteId { get; set; }

        public virtual ICollection<AccountType> AccountTypes { get; set;}
        public virtual ICollection<Site> Sites { get; set;}
        public virtual CardAccount CardAccount { get; set; }
    }
}
