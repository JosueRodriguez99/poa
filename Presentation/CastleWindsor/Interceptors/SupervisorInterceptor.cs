using System;
using Application.Institucion.ViewModels;
using Castle.DynamicProxy;
using Domain.Institucion;

namespace Presentation.CastleWindsor.Interceptors
{
    public class SupervisorInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var usuarioActual = (UsuarioViewModel)System.Web.HttpContext.Current.Session["CurrentUSer"];

            if (usuarioActual.RolUsuario == "Supervisor")
                invocation.Proceed();
            else
                throw new Exception("Sin autorizacion");
        }
    }
}