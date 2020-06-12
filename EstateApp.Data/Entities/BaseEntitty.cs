using System;
using System.Collections.Generic;
using System.Text;

namespace EstateApp.Data.Entities
{
    public abstract class BaseEntitty
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
