using System.Collections.Generic;
using Application.Institucion.Dto;
using Application.Institucion.ViewModels;
using Domain.Institucion;

namespace Application.Institucion.Services
{
    public interface IUsuarioService
    {
        void CrearUsuario(UsuarioDto request);
        void ActualizarUsuario(UsuarioDto request);
        void EliminarUsuario(int id);
        UsuarioViewModel ObtenerUsuarioPorId(int id);
        Usuario ComprobarUsuario(string nombreUsuario);
        List<UsuarioViewModel> ObtenerJefes();
        List<UsuarioViewModel> ObtenerAnalistas();
        List<UsuarioViewModel> ObtenerUsuarios();
        List<UsuarioViewModel> ObtenerUsuariosActivos();
    }
}