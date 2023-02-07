/* 
CREATE TABLE [UserRole] (
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,

    CONSTRAINT [PK_UserRole] PRIMARY KEY([UserId], [RoleId])
)
*/

namespace Blog.Model {
    public class UserRole {
        public int userId { get; set; }

        public int roleId { get; set; }
    }
}