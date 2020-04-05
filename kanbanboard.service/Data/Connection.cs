using System;
using System.Collections.Generic;
using System.Text;

namespace kanbanboard.service.Data
{
    public class Connection
    {
        public string ConnString;

        public Connection()
        {
            ConnString = "Server=localhost;Port=3306;Database=kanbanboard;Uid=root;Pwd=Cl21314Ry;Allow User Variables=True;SslMode=None;Character Set=utf8";
        }
    }
}
