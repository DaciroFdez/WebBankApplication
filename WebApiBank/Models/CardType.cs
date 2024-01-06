using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class CardType : Base
    {
        [Key] public int Id { get; set; }
        public string NameTypeCard { get; set; }
    }
}
