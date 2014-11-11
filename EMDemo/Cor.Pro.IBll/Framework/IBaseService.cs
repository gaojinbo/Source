using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cor.Pro.IBll
{
    //基仓储在业务逻辑层的约束
    public partial interface IBaseService<T> where T : class,new()
    {
        //添加实体
        int Add(T entity);

        //更新实体
        int Edit(T entity);

        //删除实体
        int Remove(T entity);

        //查询全部
        IQueryable<T> FindAll();
        IQueryable<T> FindAll(Expression<Func<T, bool>> exp);

        ////查询DBObject
        //DbSet<T> GetDBObject();

        //查询实体
        T Fetch(Expression<Func<T, bool>> exp);
    }
}
