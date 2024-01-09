using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class CardAccount : Base
    {
        [Key] public int CardAccountId { get; set; }
        public int CardNumber { get; set; }
        public int CardTypeId { get; set; }
        public int AccountId { get; set; }
        public DateTime ExpDate { get; set; }
        public int SecurityCode { get; set; }
        public int Quota { get; set; }
        

        public virtual Account Account { get; set; }
        public virtual CardType CardType { get; set; }
        public virtual CardReport Report { get; set; }
    }
}
