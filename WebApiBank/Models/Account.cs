using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBank.Models
{
    public class Account : Base
    {
        [Key] public int AccountId { get; set; }
        [ForeignKey("AccountType")] public int AccountTypeId { get; set; }
        public int NumberAccount {  get; set; }
        public int Amount { get; set; }
        [ForeignKey("Site")] public int SiteId { get; set; }

        public virtual AccountType AccountType { get; set;}
        //[InverseProperty("Accounts")]
        public virtual Site Site { get; set;}
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        public virtual ICollection<CardAccount> CardAccount { get; set; }
        public virtual ICollection<InvestmentAccount> InvestmentAccount { get; set;}
        public virtual ICollection<Transaction> TransactionOrigin { get; set; }
        public virtual ICollection<Transaction> TransactionDestiny { get; set; }
        public virtual ICollection<LoanAccount> LoanAccounts { get; set; }
    }
}
