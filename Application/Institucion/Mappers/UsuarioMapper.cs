using Application.Institucion.Dto;
using Domain.Institucion;

namespace Application.Institucion.Mappers
{
    public static class UsuarioMapper
    {
        public static UsuarioDto ToUsuarioDto(this Usuario usuario)
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
            usuario.RolUsuario = dto.RolUsuario;
            usuario.Activo = dto.Activo;
            return usuario;
        }
    }
}