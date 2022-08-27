using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng ID
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Content { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}