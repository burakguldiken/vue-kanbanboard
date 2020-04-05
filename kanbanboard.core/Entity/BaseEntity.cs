using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.core.Entity
{
    public class BaseEntity
    {
        public long id { get; set; }
        public long creatorId { get; set; }
        public DateTime creationDate { get; set; }
        public int statusId { get; set; }
    }
}
