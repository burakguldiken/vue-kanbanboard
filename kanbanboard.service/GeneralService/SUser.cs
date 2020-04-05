using kanbanboard.core.Entity;
using kanbanboard.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanbanboard.service.GeneralService
{
    public class SUser : IUser
    {
        IDbContext dbContext;
        public SUser(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public User CheckUser(string email, string password)
        {
            string sql = @"SELECT * FROM user WHERE email = @email AND password = @password AND statusId = 2";
            return dbContext.ExecuteCommand<User>(sql, email, password).FirstOrDefault();
        }
    }
}
