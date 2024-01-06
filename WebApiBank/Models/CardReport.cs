using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class CardReport : Base
    {
        [Key] public int Id { get; set; }
        public int AccountId { get; set; }
        public int Amount { get; set; }
        public int Due {  get; set; }



        public virtual Account Account { get; set; }
    }
}
