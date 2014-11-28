using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EastCarmen.IDao
{
    public interface IBaseRepository<T> where T : class,new()
    {
        //添加实体
        void Add(T entity);

        //更新实体
        void Edit(T entity);

        //删除实体
        void Remove(T entity);

        //查询全部
        IQueryable<T> FindAll();
        IQueryable<T> FindAll(Expression<Func<T, bool>> exp);

        //查询DBObject
        DbSet<T> GetDBObject();

        //查询实体
        T Fetch(Expression<Func<T, bool>> exp);
    }
}
