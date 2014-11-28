using EastCarmen.Dao;
using EastCarmen.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EastCarmen.Service
{
    public abstract class BaseService<T> where T : class,new()
    {
        //当前数据仓储对象
        public IBaseRepository<T> CurrentRepository { get; set; }
        //数据库访问入口
        public IDBSession _dbSession = DBSessionFactory.GetCurrentDbSession();

        //构造
        public BaseService()
        {
            SetCurrentRepository();
        }
        //子类必须要实现该方法 以获取当前数据仓储访问的实例！！
        public abstract void SetCurrentRepository();


        #region 基于 基仓储 的数据服务层公共实现部分

        //添加实体
        public int Add(T entity)
        {
            CurrentRepository.Add(entity);
            return _dbSession.SaveChanges();
        }

        //更新实体
        public int Edit(T entity)
        {
            CurrentRepository.Edit(entity);
            return _dbSession.SaveChanges();
        }

        //删除实体
        public int Remove(T entity)
        {
            CurrentRepository.Remove(entity);
            return _dbSession.SaveChanges();
        }

        //查询全部
        public IQueryable<T> FindAll()
        {
            return CurrentRepository.FindAll();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> exp)
        {
            return CurrentRepository.FindAll(exp);
        }


        ////查询DBObject
        //DbSet<T> GetDBObject();

        //查询实体
        public T Fetch(Expression<Func<T, bool>> exp)
        {
            return CurrentRepository.Fetch(exp);
        }



        #endregion
    }
}
