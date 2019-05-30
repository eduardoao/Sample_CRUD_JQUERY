﻿using FluentValidation;
using Domain.Entities;
using System;
using System.Text;

namespace Service.Validators
{
    public partial class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            ValidaDados();
        }

        private void ValidaDados()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto nao carregado.");
                });

            RuleFor(c => c.Email)
                .NotEmpty()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Campo email é obrigatorio.");
                });            
        }    

    }
}
