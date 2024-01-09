using System.ComponentModel.DataAnnotations;

namespace WebApiBank.Models
{
    public class CardReport : Base
    {
        [Key] public int CardReportId { get; set; }
        public int CardAccountId { get; set; }
        public int Amount { get; set; }
        public int Due {  get; set; }



        public virtual CardAccount CardAccount { get; set; }
    }
}
