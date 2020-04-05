using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.core.Entity
{
    [Table("userprojectrel")]
    public class UserProjectRel : BaseEntity
    {
        public long userId { get; set; }
        public long projectId { get; set; }
    }
}
