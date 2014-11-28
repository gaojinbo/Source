using EastCarmen.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;


namespace EastCarmen.Dao
{
    public class DBSessionFactory
    {
        /// <summary>
        /// 获取DbSession唯一实例
        /// </summary>
        /// <returns></returns>
        public static IDBSession GetCurrentDbSession()
        {
            IDBSession _dbSession = CallContext.GetData("DbSession") as IDBSession;
            if (_dbSession == null)
            {
                _dbSession = new DBSession();
                CallContext.SetData("DbSession", _dbSession);
            }
            return _dbSession;
        }

    }
}
