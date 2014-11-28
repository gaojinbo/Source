using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastCarmen.IDao
{
    public partial interface IDBSession
    {
        int SaveChanges();

        int ExcuteSql(string strSql, params Object[] parameters);
    }
}
