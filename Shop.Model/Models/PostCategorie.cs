using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategorie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng ID
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int ParentID { set; get; }
        public int DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}