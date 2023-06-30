using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Display Order is required"), DisplayName("Display Order")]
        public string DisplayOrder { get; set; }
        [Required(ErrorMessage ="Date is required"), DisplayName("Date")]
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
