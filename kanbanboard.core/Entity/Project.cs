using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.core.Entity
{
    [Table("project")]
    public class Project : BaseEntity
    {
        public string name { get; set; }
        public string key { get; set; }
        public string type { get; set; }
        public string lead { get; set; }
    }
}
