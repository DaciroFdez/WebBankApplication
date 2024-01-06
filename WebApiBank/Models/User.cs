using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;

namespace WebApiBank.Models
{
    public class User : Base
    {
        [Key]
        [Column("UserId")]
        public int Id { get; set; }
        //Clave foranea
        [ForeignKey("DocumentType")]
        public int DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        [Column("FirstName")]
        public string NameUser { get; set; }
        [ForeignKey("UserType")]
        public int UserTypeId { get; set; }
        [ForeignKey("Site")]
        public int SiteId { get; set; }


        //propiedad de navegación
        public virtual DocumentType DocumentType { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual Site Site { get; set; }
        public virtual ICollection<UserAccount> UsersAccounts { get; set; }
    }
}
