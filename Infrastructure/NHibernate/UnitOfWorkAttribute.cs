using System;

namespace Infrastructure.NHibernate
{
    [AttributeUsage(AttributeTargets.Method)]
    public class UnitOfWorkAttribute : Attribute
    {

    }
}