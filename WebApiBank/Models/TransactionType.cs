using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class TransactionType : Base
    {
        [Key] public int Id { get; set; }
        public string TransactionName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set;}

    }
}
