using DesafioFiap.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesafioFiap.Models.Validation
{
    public class EmailExistsInDatabase : ValidationAttribute
    {
        private readonly ApplicationDbContext _context;

        public EmailExistsInDatabase()
        {
            _context = new ApplicationDbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var usuario = (UsuarioNewsletterDtoIn)validationContext.ObjectInstance;

            var totalEmailsFound = _context.UsuariosNewsletter
                .Count(u => u.Email.ToUpper() == usuario.Email.ToUpper());

            return (totalEmailsFound > 0)
                ? new ValidationResult("Este email já está cadastrado")
                : ValidationResult.Success;
        }
    }
}