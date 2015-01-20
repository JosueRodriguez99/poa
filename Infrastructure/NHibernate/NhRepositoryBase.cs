using Domain.Common;
using NHibernate;
using NHibernate.Linq;
using System.Linq;

namespace Infrastructure.NHibernate
{
    public abstract class NhRepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : IAggregateRoot
    {
        protected ISession Session 
        { 
            get { return NhUnitOfWork.Current.Session; } 
        }

        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        public TEntity Get(TPrimaryKey key)
        { 
            return Session.Get<TEntity>(key);
        }

        public void Insert(TEntity entity)
        {
            Session.Save(entity);
        }

        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        public void Delete(TPrimaryKey id)
        {
            Session.Delete(Session.Load<TEntity>(id));
        }
    }
}