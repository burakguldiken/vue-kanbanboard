using Dapper;
using Dapper.Contrib.Extensions;
using kanbanboard.core.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace kanbanboard.service.Data
{
    public class DbContext : IDbContext
    {
        Connection _Connection = new Connection();

        public IEnumerable<object> User => throw new NotImplementedException();

        public T GetByID<T>(long _ID) where T : class, new()
        {
            T _Item = new T();
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    _Item = _Conn.Get<T>(_ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Item;
        }

        public IEnumerable<T> GetList<T>(params object[] _Values) where T : class, new()
        {
            IEnumerable<T> _TList;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    _TList = _Conn.GetAll<T>();
                }
            }
            catch (Exception ex)
            {
                _TList = new List<T>();
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _TList;
        }

        public long Insert<T>(T _Item) where T : class, new()
        {
            long _ID = 0;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    _ID = _Conn.Insert(_Item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _ID;
        }

        public bool Update<T>(T _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    _Rtn = _Conn.Update(_Item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public bool Delete<T>(T _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    _Rtn = _Conn.Delete(_Item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public IEnumerable<T> ExecuteCommand<T>(string _Command, params object[] _Values)
        {
            IEnumerable<T> _TList;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    _TList = _Conn.Query<T>(_Command, CreateParams(GetMethodName(), _Values));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
                _TList = new List<T>();
            }
            return _TList;
        }

        public bool BulkInsert<T>(List<T> _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    foreach (var item in _Item)
                    {
                        _Conn.Insert(item);
                    }
                    _Rtn = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public bool BulkUpdate<T>(List<T> _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    foreach (var item in _Item)
                    {
                        _Conn.Update(item);
                    }
                    _Rtn = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public bool BulkDelete<T>(List<T> _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_Connection.ConnString))
                {
                    foreach (var item in _Item)
                    {
                        _Conn.Delete(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public MethodInfo GetMethodName()
        {
            var trace = new StackTrace();
            return (MethodInfo)trace.GetFrame(2).GetMethod();
        }

        public DynamicParameters CreateParams(MethodInfo _Method, params object[] _Values)
        {
            DynamicParameters sqlParams = new DynamicParameters();
            int paramIndex = 0;
            ParameterInfo[] methodParameters = _Method.GetParameters();
            foreach (ParameterInfo paramInfo in methodParameters)
            {
                sqlParams.Add(paramInfo.Name, _Values[paramIndex]);
                paramIndex++;
            }
            return sqlParams;
        }
    }
}
