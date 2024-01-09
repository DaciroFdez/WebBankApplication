using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBank.Models
{
    public class Transaction : Base
    {
        [Key] public int TransactionId { get; set; }
        [ForeignKey("AccountOrigin")] public int AccountOriginId { get; set; }
        [ForeignKey("AccountDestination")] public int AccountDestinationId {  get; set; }
        public decimal Amount { get; set; }
        [ForeignKey("TransactionType")] public int TransactionTypeId { get; set; }

        public virtual Account AccountOrigin { get; set; }
        public virtual Account AccountDestination { get; set;}
        public virtual TransactionType TransactionType { get; set; }
    }
}
