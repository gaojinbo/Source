using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.IDal;
using Cor.Pro.Dal.Framework;

//数据访问层的实现
namespace Cor.Pro.Dal
{
    //数据访层统一入口的实现
    public partial class DbSession : IDbSession
    {
        //数据操作的提交
        //采用UnitWork(单元工作模式) 即在BLL层上执行该提交操作
        public int SaveChanges()
        {
            //调用EF的SaveChanges()方法
            return EFContextFactory.GetCurrentContext().SaveChanges();
        }

        //执行SQL脚本的实现
        public int ExcuteSql(string strSql, params object[] parameters)
        {
            if (parameters == null)
            {
                return EFContextFactory.GetCurrentContext().Database.ExecuteSqlCommand(strSql);
            }

            return EFContextFactory.GetCurrentContext().Database.ExecuteSqlCommand(strSql, parameters);
        }



        //数据访问层统一入口处
        //Person类数据访问层实现类
        //此处可以独立出去 采用T4实现
        public IPersonRepository PersonRepository
        {
            get { return new PersonRepository(); }
        }

    }
}
