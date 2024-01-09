using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class UserType : Base
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<User> Users { get;}
    }
}
