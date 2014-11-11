using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dal层接口规范
namespace Cor.Pro.IDal
{
    //1.IDbSession 数据访问层统一入口
    //2.该接口规定了两大 数据层基本功能：提交&执行SQL
    //3.部分类实现了接口功能的扩展
    public partial interface IDbSession
    {
        int SaveChanges();

        int ExcuteSql(string strSql, params Object[] parameters);

    }

    //1.此处可采用T4实现所有类对应访问接口实现
    //2.部分类 实现了上述接口的扩展
    //3.IDbSession接口也规范 所有实体类的数据访问层接口
    public partial interface IDbSession
    {
        //示例：Person类数据访问层接口
        IPersonRepository PersonRepository { get; }
    }


}
