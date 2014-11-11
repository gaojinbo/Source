using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//Dal层数据接口规范
namespace Cor.Pro.IDal
{
    //1.基础仓储功能规范(常用：增删改查分页等)
    //2.其它类的数据仓储类 均继承此类 以达到公用该规范部分
    //3.术语：基仓储实现的方法
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
