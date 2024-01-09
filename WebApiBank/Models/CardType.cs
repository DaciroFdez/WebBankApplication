using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class CardType : Base
    {
        [Key] public int CardTypeId { get; set; }
        public string NameTypeCard { get; set; }

        public virtual ICollection<CardAccount> CardAccount { get; set; }
    }
}
