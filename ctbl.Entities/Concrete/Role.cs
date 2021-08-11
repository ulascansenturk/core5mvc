using System.Collections;
using System.Collections.Generic;
using ctbl.Shared.Entities.Abstract;

namespace ctbl.Entities.Concrete
{
    public class Role:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
        
        
    }
}