using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class CardAccount : Base
    {
        [Key] public int Id { get; set; }
        public int CardNumber { get; set; }
        public int CardType { get; set; }
        public int AccountId { get; set; }
        public DateTime ExpDate { get; set; }
        public int SecurityCode { get; set; }
        public int Quota { get; set; }
        

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<CardType> CardTypes { get; set; }
        public virtual CardReport Report { get; set; }
    }
}
