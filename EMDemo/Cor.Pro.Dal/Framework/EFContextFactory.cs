using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Cor.Pro.Model;

namespace Cor.Pro.Dal.Framework
{
    //EF上下文工厂
    public partial class EFContextFactory
    {
        /// <summary>
        /// 获取上下文唯一实例  (在EF4.0以前使用ObjectsContext对象)
        /// CallContext:是线程内部唯一的独用的数据槽(一块内存空间)
        /// 当第二次执行的时候直接取出线程嘈里面的对象
        /// 数据存储在线程栈中  线程内共享一个单例
        /// </summary>
        /// <returns></returns>
        public static DbContext GetCurrentContext()
        {
            DbContext dbcontext = CallContext.GetData("DbContext") as DbContext;
            if (dbcontext == null)
            {
                dbcontext = new Entities();
                CallContext.SetData("DbContext", dbcontext);
            }

            return dbcontext;
        }

    }
}
