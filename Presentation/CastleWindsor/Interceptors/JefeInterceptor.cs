using System;
using Castle.DynamicProxy;
using Domain.Institucion;

namespace Presentation.CastleWindsor.Interceptors
{
    public class JefeInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var usuarioActual = (Usuario)System.Web.HttpContext.Current.Session["CurrentUSer"];

            if (usuarioActual.RolUsuario == RolUsuario.Jefe)
                invocation.Proceed();    
            else
                throw new Exception("Sin autorizacion");
        }
    }
}