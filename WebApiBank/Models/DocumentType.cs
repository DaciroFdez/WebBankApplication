using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBank.Models
{
    public class DocumentType : Base
    {
        [Key]
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string Initial {  get; set; }

        [InverseProperty("DocumentType")]
        public virtual ICollection<User> Users { get; set; }
    }
}
