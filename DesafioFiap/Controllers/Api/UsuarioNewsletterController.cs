using AutoMapper;
using DesafioFiap.Dtos;
using DesafioFiap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DesafioFiap.Controllers.Api
{
    public class UsuarioNewsletterController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public UsuarioNewsletterController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/UsuarioNewsletter/
        public IHttpActionResult GetUsuarios()
        {
            var usuariosDtos = _context.UsuariosNewsletter
                .ToList()
                .Select(Mapper.Map<UsuarioNewsletter, UsuarioNewsletterDtoOut>);

            return Ok(usuariosDtos);
        }

        // GET /api/UsuarioNewsletter/1
        public IHttpActionResult GetUsuario(int id)
        {
            var usuario = _context.UsuariosNewsletter.SingleOrDefault(u => u.Id == id);

            if (usuario == null)
                return NotFound();

            return Ok(Mapper.Map<UsuarioNewsletter, UsuarioNewsletterDtoOut>(usuario));
        }

        // POST /api/UsuarioNewsletter/
        [HttpPost]
        public IHttpActionResult CreateUsuario(UsuarioNewsletterDtoIn usuarioNewsletterDtoIn)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var usuario = Mapper.Map<UsuarioNewsletterDtoIn, UsuarioNewsletter>(usuarioNewsletterDtoIn);

            _context.UsuariosNewsletter.Add(usuario);
            _context.SaveChanges();

            var usuarioDtoOut = Mapper.Map<UsuarioNewsletter, UsuarioNewsletterDtoOut>(usuario);

            return Created(new Uri(Request.RequestUri + "/" + usuario.Id), usuarioDtoOut);
        }

        // PUT /api/UsuarioNewsletter/1
        [HttpPut]
        public IHttpActionResult UpdateUsuario(int id, UsuarioNewsletterDtoIn usuarioNewsletterDtoIn)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var usuario = _context.UsuariosNewsletter.SingleOrDefault(u => u.Id == id);

            if (usuario == null)
                return NotFound();

            Mapper.Map(usuarioNewsletterDtoIn, usuario);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/UsuarioNewsletter/1
        [HttpDelete]
        public IHttpActionResult DeleteUsuario(int id)
        {
            var usuario = _context.UsuariosNewsletter.SingleOrDefault(u => u.Id == id);

            if (usuario == null)
                return NotFound();

            _context.UsuariosNewsletter.Remove(usuario);
            _context.SaveChanges();

            return Ok();
        }
    }
}
