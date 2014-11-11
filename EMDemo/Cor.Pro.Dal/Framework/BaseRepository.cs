using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.IDal;
using System.Data.Entity;
using Cor.Pro.Dal.Framework;
using System.Linq.Expressions;

namespace Cor.Pro.Dal
{
    //基仓储的实现
    public class BaseRepository<T> where T : class
    {
        //数据访问入口
        public IDbSession _dbSession = DbSessionFactory.GetCurrentDbSession();
        //EF上下文实例
        public DbContext _dbContext = EFContextFactory.GetCurrentContext();

        //数据操作的统一提交(UnitWork)
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        #region 基仓储操作实现

        #endregion

        //添加实体
        public void Add(T entity)
        {
            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry<T>(entity).State = EntityState.Added;
        }


        //更新实体
        public void Edit(T entity)
        {
            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        //删除实体
        public void Remove(T entity)
        {
            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry<T>(entity).State = EntityState.Deleted;
        }

        //查询全部
        public IQueryable<T> FindAll()
        {
            return _dbContext.Set<T>().AsQueryable();
        }
        public IQueryable<T> FindAll(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().Where(exp);
        }

        //查询DBObject
        public DbSet<T> GetDBObject()
        {
            return _dbContext.Set<T>();
        }

        //查询实体
        public T Fetch(Expression<Func<T, bool>> exp)
        {
            T entity = _dbContext.Set<T>().FirstOrDefault(exp);

            return entity;
        }

    }
}
