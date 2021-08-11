using System;

namespace ctbl.Shared.Entities.Abstract
{
    public abstract class  EntityBase
    {
        public virtual  int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedBy { get; set; } = "Admin";
        public virtual string ModifiedBy { get; set; } = "Admin";
        public string Note { get; set; }
        
    }
}