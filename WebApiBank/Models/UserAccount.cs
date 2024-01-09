using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class UserAccount
    {
        [Key]public int UserAccoutId { get; set; }
        public int UserId { get; set; }
        public int AccountId { get; set; }

        public virtual User Users { get; set; }
        public virtual Account Accounts { get; set; }
    }
}
