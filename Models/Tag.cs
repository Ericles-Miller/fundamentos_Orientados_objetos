/* 
[Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(80) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
*/


namespace Blog.Model {
    public class Tag {
        public int id { get; set; }

        public string name { get; set; }

        public string slug { get; set; }
    }
}