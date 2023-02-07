/* 
[Id] INT NOT NULL IDENTITY(1, 1),
    [Name] NVARCHAR(80) NOT NULL,
    [Email] VARCHAR(200) NOT NULL,
    [PasswordHash] VARCHAR(255) NOT NULL,
    [Bio] TEXT NOT NULL,
    [Image] VARCHAR(2000) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
*/

namespace Blog.Models {
    public class User {
        public int id { get; set; }
        
        public string name { get; set; }

        public string email { get; set; }

        public string passwordHash { get; set; }

        public string bio { get; set; }

        public string image { get; set; }

        public string slug { get; set; }
    }
}