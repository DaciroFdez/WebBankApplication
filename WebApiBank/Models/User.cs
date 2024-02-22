using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiBank.Models
{
    public class User : Base
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
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
        [JsonIgnore]
        public virtual DocumentType DocumentType { get; set; }
        [JsonIgnore]
        public virtual UserType UserType { get; set; }
        [JsonIgnore]
        public virtual Site Site { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserAccount> UsersAccount { get; set; }
    }
}
