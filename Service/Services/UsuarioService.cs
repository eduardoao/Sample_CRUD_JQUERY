using FluentValidation;
using Data.Repostitory;
using Domain.Entities;
using System;
using Service.Validators;
using System.Text;

namespace Service.Services
{
    public class UsuarioService<T> : BaseService<T> where T : Usuario
    {       

        private UsuarioRepositorio<Usuario> repository = new UsuarioRepositorio<Usuario>();
        

        public override T Post<V>(T entity) 
        {
            Validate(entity, Activator.CreateInstance<V>());
            entity.SenhaHash = UsuarioRules.CalculateSHA1(entity.SenhaHash);
            repository.Insert(entity);
            return entity;
        }

        public T PostLogin<V>(T entity) where V : AbstractValidator<T>
        {
            //Validate(entity, Activator.CreateInstance<V>());
            entity.SenhaHash = UsuarioRules.CalculateSHA1(entity.SenhaHash);
            var objetousuario = repository.SelectEmail(entity);
            entity.Id = objetousuario.Id;

            var emailhash = UsuarioRules.CalculateSHA1(objetousuario.SenhaHash, Encoding.ASCII);
            
            if (entity.SenhaHash != emailhash)               
                    throw new ArgumentException("e-mail inválido!");
            
            return entity;
        }


        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
