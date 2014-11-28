using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.IDao;

namespace EastCarmen.Dao
{
    public partial class DBSession : IDBSession
    {
        public int SaveChanges()
        {
            return EFContextFactory.GetCurrentContext().SaveChanges();
        }

        public int ExcuteSql(string strSql, params object[] parameters)
        {
            if (parameters == null)
            {
                return EFContextFactory.GetCurrentContext().Database.ExecuteSqlCommand(strSql);
            }

            return EFContextFactory.GetCurrentContext().Database.ExecuteSqlCommand(strSql, parameters);
        }
    }
}
