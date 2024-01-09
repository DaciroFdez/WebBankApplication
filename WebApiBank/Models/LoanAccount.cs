using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class LoanAccount : Base
    {
        [Key] public int LoanId { get; set; }
        public int LoanCode { get; set; }
        public int LoanAmount { get; set; }
        public int LoanStatus { get; set; }
        public int LoanTypeId { get; set; }
        public int AccountId { get; set; }

        public virtual LoanType LoanType { get; set; }
        public virtual Account Account { get; set; }

    }
}
