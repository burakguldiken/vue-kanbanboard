using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace kanbanboard.core.Entity
{
    [Table("user")]
    public class User : BaseEntity
    {
        [MaxLength(255)]
        public string name { get; set; }
        [MaxLength(255)]
        public string surname { get; set; }
        [MaxLength(255)]
        public string email { get; set; }
        [MaxLength(255)]
        public string address { get; set; }
        [MaxLength(255)]
        public string phone { get; set; }
        [MaxLength(255)]
        public string password { get; set; }
    }
}
