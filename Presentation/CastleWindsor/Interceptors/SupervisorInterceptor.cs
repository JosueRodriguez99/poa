using System;
using Castle.DynamicProxy;
using Domain.Institucion;

namespace Presentation.CastleWindsor.Interceptors
{
    public class SupervisorInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var usuarioActual = (Usuario)System.Web.HttpContext.Current.Session["CurrentUSer"];

            if (usuarioActual.RolUsuario == RolUsuario.Supervisor)
                invocation.Proceed();
            else
                throw new Exception("Sin autorizacion");
        }
    }
}