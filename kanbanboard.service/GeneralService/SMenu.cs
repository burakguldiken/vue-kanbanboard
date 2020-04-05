using kanbanboard.core.Entity;
using kanbanboard.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanbanboard.service.GeneralService
{
    public class SMenu : IMenu
    {
        IDbContext dbContext;
        public SMenu(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Menu> GetUserMenus()
        {
            string sql = @"SELECT * FROM menu WHERE statusId = 2";
            return dbContext.ExecuteCommand<Menu>(sql).ToList();
        }
    }
}
