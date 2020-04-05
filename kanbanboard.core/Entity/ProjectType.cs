using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.core.Entity
{
    [Table("projecttype")]
    public class ProjectType : BaseEntity
    {
        public string name { get; set; }
    }
}
