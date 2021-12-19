using Blog.Core.Models.Base;
using System.Collections.Generic;

namespace Blog.Models
{
    public class User : EntityBase, IEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserName { get; set; }
        public string ImagePateh { get; set; }
        public string Description { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
