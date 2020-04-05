using kanbanboard.core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanbanboard.api.Models
{
    public class UserModel
    {
        public User user { get; set; }
        public List<Menu> menus { get; set; }
        public string token { get; set; }
    }
}
