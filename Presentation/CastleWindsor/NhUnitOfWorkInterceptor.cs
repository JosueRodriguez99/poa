using System;
using System.Reflection;
using Castle.DynamicProxy;
using Infrastructure.NHibernate;
using NHibernate;
using IInterceptor = Castle.DynamicProxy.IInterceptor;

namespace Presentation.CastleWindsor
{
    public class NhUnitOfWorkInterceptor : IInterceptor
    {
        private readonly ISessionFactory _sessionFactory;

        public NhUnitOfWorkInterceptor(ISessionFactory sessionFactory)
        {
            if (sessionFactory == null) throw new ArgumentNullException("sessionFactory");
            _sessionFactory = sessionFactory;
        }

        public void Intercept(IInvocation invocation)
        {
            if (NhUnitOfWork.Current != null || !RequiresDbConnection(invocation.MethodInvocationTarget))
            {
                invocation.Proceed();
                return;
            }

            try
            {
                NhUnitOfWork.Current = new NhUnitOfWork(_sessionFactory);
                NhUnitOfWork.Current.BeginTransaction();

                try
                {
                    invocation.Proceed();
                    NhUnitOfWork.Current.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        NhUnitOfWork.Current.Rollback();
                    }
                    catch (Exception innerEx)
                    {
                        throw new Exception(ex.Message + " || " + innerEx.Message);
                    }

                    throw;
                }
            }
            finally
            {
                NhUnitOfWork.Current = null;
            }
        }

        private static bool RequiresDbConnection(MethodInfo methodInfo)
        {
            if (methodInfo == null) throw new ArgumentNullException("methodInfo");

            if (UnitOfWorkHelper.HasUnitOfWorkAttribute(methodInfo)) return true;

            if (UnitOfWorkHelper.IsRepositoryMethod(methodInfo)) return true;

            return false;
        }
    }
}