using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Shop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng ID
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        [MaxLength(250)]
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Warranty { set; get; }

        [MaxLength(250)]
        public string Description { set; get; }

        [MaxLength(250)]
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}