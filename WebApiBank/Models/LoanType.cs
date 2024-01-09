using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class LoanType : Base
    {
        [Key] public int LoanTypeId { get; set; }
        public string LoanTypeName { get; set; }

        public virtual ICollection<LoanAccount> LoanAccounts { get; set; }
    }
}
