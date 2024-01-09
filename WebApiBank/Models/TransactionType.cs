using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class TransactionType : Base
    {
        [Key] public int TransactionTypeId { get; set; }
        public string TransactionName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set;}

    }
}
