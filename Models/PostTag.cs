/* 
CREATE TABLE [UserRole] (
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,

    CONSTRAINT [PK_UserRole] PRIMARY KEY([UserId], [RoleId])
)
*/

namespace Blog.Model {
    public class PostTag {
        public int postId { get; set; }

        public int tagId { get; set; }
    }
}