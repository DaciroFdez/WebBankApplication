using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class Transaction : Base
    {
        [Key] public int Id { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId {  get; set; }
        public decimal Amount { get; set; }

        public virtual Account OriginAccount { get; set; }
        public virtual Account DestinationAccount { get; set;}
        public virtual TransactionType TransactionType { get; set; }
    }
}
