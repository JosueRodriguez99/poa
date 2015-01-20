using System.Collections.Generic;
using Application.Institucion.Dto;

namespace Application.Institucion.Services
{
    public interface IUsuarioService
    {
        void CrearUsuario(UsuarioDto request);
        void ActualizarUsuario(UsuarioDto request);
        void EliminarUsuario(int id);
        UsuarioDto ObtenerUsuarioPorId(int id);
        List<UsuarioDto> ObtenerJefes();
        List<UsuarioDto> ObtenerAnalistas();
        List<UsuarioDto> ObtenerUsuarios();
        List<UsuarioDto> ObtenerUsuariosActivos();
    }
}