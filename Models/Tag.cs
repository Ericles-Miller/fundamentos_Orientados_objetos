/* 
[Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(80) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
*/




using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Model {
    [Table("Tag")]
    public class Tag {
        [Key] 
        public int id { get; set; }

        public string name { get; set; }

        public string slug { get; set; }
    }
}