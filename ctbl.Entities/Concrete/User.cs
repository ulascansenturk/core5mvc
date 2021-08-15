using System.Collections;
using System.Collections.Generic;
using ctbl.Shared.Entities.Abstract;

namespace ctbl.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public byte[] PasswordHash { get; set; }
        public string  Username{ get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Article> Articles { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}