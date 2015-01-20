using System.Collections.Generic;
using System.Linq;
using Application.Institucion.Dto;
using Application.Institucion.Mappers;
using Domain.Institucion;
using System;
using Infrastructure.NHibernate;

namespace Application.Institucion.Services
{
    public class UsuarioService : IUsuarioService  
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
        }

        public void CrearUsuario(UsuarioDto request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Insert(request.ToUsuario());

        }

        public void ActualizarUsuario(UsuarioDto request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Update(request.ToUsuario());
        }

        public void EliminarUsuario(int id)
        {
            _repository.Delete(id);
        }

        public UsuarioDto ObtenerUsuarioPorId(int id)
        {
            return _repository.Get(id).ToUsuarioDto();
        }

        [UnitOfWork]
        public List<UsuarioDto> ObtenerJefes()
        {
            var usuariosDto = new List<UsuarioDto>();
            var usuarios = _repository.GetAll().Where(x => x.RolUsuario == RolUsuario.Jefe).ToList();

            foreach (var usuario in usuarios)
                usuariosDto.Add(usuario.ToUsuarioDto());

            return usuariosDto;
        }

        [UnitOfWork]
        public List<UsuarioDto> ObtenerAnalistas()
        {
            var usuariosDto = new List<UsuarioDto>();
            var usuarios = _repository.GetAll().Where(x => x.RolUsuario == RolUsuario.Analista).ToList();

            foreach (var usuario in usuarios)
                usuariosDto.Add(usuario.ToUsuarioDto());

            return usuariosDto;
        }

        [UnitOfWork]
        public List<UsuarioDto> ObtenerUsuarios()
        {
            var usuariosDto = new List<UsuarioDto>();
            var usuarios = _repository.GetAll().ToList();

            foreach (var usuario in usuarios)
                usuariosDto.Add(usuario.ToUsuarioDto());

            return usuariosDto;
        }

        [UnitOfWork]
        public List<UsuarioDto> ObtenerUsuariosActivos()
        {
            var usuariosDto = new List<UsuarioDto>();
            var usuarios = _repository.GetAll().Where(x => x.Activo).ToList();

            foreach (var usuario in usuarios)
                usuariosDto.Add(usuario.ToUsuarioDto());

            return usuariosDto;
        }
    }
}