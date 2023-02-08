
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Model {
    [Table("Category")]
    public class Category{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        [Column("Name", TypeName ="NVARCHAR")]
        public string name { get; set; }

        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        [Column("Slug", TypeName ="VARCHAR")]
        public string slug { get; set; }
    }
}