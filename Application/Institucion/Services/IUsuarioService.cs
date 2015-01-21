using System.Collections.Generic;
using Application.Institucion.Dto;
using Application.Institucion.ViewModels;

namespace Application.Institucion.Services
{
    public interface IUsuarioService
    {
        void CrearUsuario(UsuarioDto request);
        void ActualizarUsuario(UsuarioDto request);
        void EliminarUsuario(int id);
        UsuarioDto ObtenerUsuarioPorId(int id);
        List<UsuarioViewModel> ObtenerJefes();
        List<UsuarioViewModel> ObtenerAnalistas();
        List<UsuarioViewModel> ObtenerUsuarios();
        List<UsuarioViewModel> ObtenerUsuariosActivos();
    }
}