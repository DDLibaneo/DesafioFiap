using AutoMapper;
using DesafioFiap.Dtos;
using DesafioFiap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace DesafioFiap.Controllers
{
    public class UsuarioNewsletterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioNewsletterController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: UsuarioNewsletter
        public ActionResult Index()
        {
            return View("Form");
        }

        public ActionResult New()
        {
            return View("Form");
        }

        [Authorize]
        public ActionResult Administration()
        {
            return View("Administration");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public ActionResult Save(UsuarioNewsletterDtoIn usuarioNewsletterDtoIn)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", usuarioNewsletterDtoIn);
            }

            var usuarioNewsletter = Mapper
                .Map<UsuarioNewsletterDtoIn, UsuarioNewsletter>(usuarioNewsletterDtoIn);

            _context.UsuariosNewsletter.Add(usuarioNewsletter);

            _context.SaveChanges();

            var usuarioNewsletterDtoOut = Mapper
                .Map<UsuarioNewsletter, UsuarioNewsletterDtoOut>(usuarioNewsletter);

            return View("SubscriptionSuccessful", usuarioNewsletterDtoOut);
        }
    }
}