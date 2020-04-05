using kanbanboard.core.Interfaces;
using kanbanboard.service.Data;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace kanbanboard.service.GeneralService
{
    public class SMethod : IMethod
    {
        public SMethod()
        {
            IDbContext dbContext = new DbContext();
        }

        public string Md5Password(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(password);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
