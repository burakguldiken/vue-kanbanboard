using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.core.Entity
{
    [Table("menu")]
    public class Menu : BaseEntity
    {
        public int parentMenuId { get; set; }
        public int ProductId { get; set; }
        public string name { get; set; }
        public string apiPath { get; set; }
        public string route { get; set; }
        public string icon { get; set; }
        public int priority { get; set; }
        public int isShow { get; set; }
    }
}
