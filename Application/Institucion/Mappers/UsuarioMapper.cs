using Application.Institucion.Dto;
using Application.Institucion.ViewModels;
using Domain.Institucion;

namespace Application.Institucion.Mappers
{
    public static class UsuarioMapper
    {
        public static UsuarioDto ToDto(this Usuario usuario)
        {
            var dto = new UsuarioDto();
            dto.Id = usuario.Id;
            dto.NombreUsuario = usuario.NombreUsuario;
            dto.RolUsuario = dto.RolUsuario;
            dto.Activo = usuario.Activo;
            return dto;
        }

        public static Usuario ToUsuario(this UsuarioDto dto)
        {
            var usuario = new Usuario();
            usuario.Id = dto.Id;
            usuario.NombreUsuario = dto.NombreUsuario;
            usuario.RolUsuario = (RolUsuario)dto.RolUsuario;
            usuario.Activo = dto.Activo;
            return usuario;
        }

        public static UsuarioViewModel ToViewModel(this Usuario usuario)
        {
            var viewModel = new UsuarioViewModel();
            viewModel.Id = usuario.Id;
            viewModel.NombreUsuario = usuario.NombreUsuario;
            viewModel.RolUsuario = usuario.RolUsuario.ToString();
            viewModel.Estado = (usuario.Activo) ? "Activo" : "Inactivo";
            return viewModel;
        }
    }
}