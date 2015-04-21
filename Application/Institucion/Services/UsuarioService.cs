using System.Collections.Generic;
using System.Linq;
using Application.Institucion.Dto;
using Application.Institucion.Mappers;
using Application.Institucion.ViewModels;
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
            _repository.Insert(request.ToEntity());

        }

        public void ActualizarUsuario(UsuarioDto request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Update(request.ToEntity());
        }

        public void EliminarUsuario(int id)
        {
            _repository.Delete(id);
        }

        public UsuarioViewModel ObtenerUsuarioPorId(int id)
        {
            return _repository.Get(id).ToViewModel();
        }

        [UnitOfWork]
        public Usuario ComprobarUsuario(string nombreUsuario)
        {
            var usuarios = _repository.GetAll().Where(x => x.NombreUsuario == nombreUsuario).ToList();
            if (usuarios.Count == 0) throw new Exception("Usuario no registrado en el sistema");
            return usuarios[0];
        }

        [UnitOfWork]
        public List<UsuarioViewModel> ObtenerJefes()
        {
            var usuarioViewModels = new List<UsuarioViewModel>();
            var usuarios = _repository.GetAll().Where(x => x.RolUsuario == RolUsuario.Jefe).ToList();

            foreach (var usuario in usuarios)
                usuarioViewModels.Add(usuario.ToViewModel());

            return usuarioViewModels;
        }

        [UnitOfWork]
        public List<UsuarioViewModel> ObtenerAnalistas()
        {
            var usuarioViewModels = new List<UsuarioViewModel>();
            var usuarios = _repository.GetAll().Where(x => x.RolUsuario == RolUsuario.Analista).ToList();

            foreach (var usuario in usuarios)
                usuarioViewModels.Add(usuario.ToViewModel());

            return usuarioViewModels;
        }

        [UnitOfWork]
        public List<UsuarioViewModel> ObtenerUsuarios()
        {
            var usuarioViewModels = new List<UsuarioViewModel>();
            var usuarios = _repository.GetAll().ToList();

            foreach (var usuario in usuarios)
                usuarioViewModels.Add(usuario.ToViewModel());

            return usuarioViewModels;
        }

        [UnitOfWork]
        public List<UsuarioViewModel> ObtenerUsuariosActivos()
        {
            var usuarioViewModels = new List<UsuarioViewModel>();
            var usuarios = _repository.GetAll().Where(x => x.Activo).ToList();

            foreach (var usuario in usuarios)
                usuarioViewModels.Add(usuario.ToViewModel());

            return usuarioViewModels;
        }
    }
}