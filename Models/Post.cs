/*

CREATE TABLE [Post] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [CategoryId] INT NOT NULL,
    [AuthorId] INT NOT NULL,
    [Title] VARCHAR(160) NOT NULL,
    [Summary] VARCHAR(255) NOT NULL,
    [Body] TEXT NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
    [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    */

namespace Blog.Model {
    public class Post {
        public int id { get; set; }

        public int categoryId { get; set; }

        public int authorId { get; set; }

        public string title { get; set; }

        public string summary { get; set; }

        public string body { get; set; }

        public string slug { get; set; }

        public DateTime createDate { get; set; }

        public DateTime lastUpdateDate { get; set; }
    }
}