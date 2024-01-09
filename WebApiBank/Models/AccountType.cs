using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class AccountType
    {
        [Key] public int AccountTypeId {  get; set; }
        public string AccountTypename { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        
    }
}
