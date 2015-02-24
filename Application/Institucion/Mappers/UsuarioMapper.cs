using Application.Institucion.Dto;
using Application.Institucion.ViewModels;
using Domain.Institucion;

namespace Application.Institucion.Mappers
{
    public static class UsuarioMapper
    {
<<<<<<< HEAD
        public static Usuario ToEntity(this UsuarioDto dto)
=======
        public static Usuario ToUsuario(this UsuarioDto dto)
>>>>>>> origin
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