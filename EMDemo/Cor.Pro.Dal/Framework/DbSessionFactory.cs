using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.IDal;
using System.Runtime.Remoting.Messaging;

namespace Cor.Pro.Dal
{
    //数据访问入口工厂
    public class DbSessionFactory
    {
        /// <summary>
        /// 获取DbSession唯一实例
        /// </summary>
        /// <returns></returns>
        public static IDbSession GetCurrentDbSession()
        {
            IDbSession _dbSession = CallContext.GetData("DbSession") as IDbSession;
            if (_dbSession == null)
            {
                _dbSession = new DbSession();
                CallContext.SetData("DbSession", _dbSession);
            }
            return _dbSession;
        }

    }
}
