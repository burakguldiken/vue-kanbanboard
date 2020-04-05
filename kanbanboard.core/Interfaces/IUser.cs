using kanbanboard.core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.core.Interfaces
{
    public interface IUser
    {
        User CheckUser(string email, string password);
    }
}
