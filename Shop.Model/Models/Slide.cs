
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng ID
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [Required]
        [MaxLength(250)]
        public string Image { set; get; }

        [Required]
        [MaxLength(250)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }
        [Required]
        public bool Status { set; get; } 
    }
}
