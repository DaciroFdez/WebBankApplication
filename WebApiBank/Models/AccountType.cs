using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class AccountType
    {
        [Key] public int Id {  get; set; }
        public string AccountTypename { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        
    }
}
