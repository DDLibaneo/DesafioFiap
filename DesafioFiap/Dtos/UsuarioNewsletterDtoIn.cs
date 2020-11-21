﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DesafioFiap.Dtos
{
    public class UsuarioNewsletterDtoIn
    {
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }
    }
}