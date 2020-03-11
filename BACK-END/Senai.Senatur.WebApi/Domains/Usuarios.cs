using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int IdUsuarios { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? IdTiposUsuarios { get; set; }

        public TiposUsuarios IdTiposUsuariosNavigation { get; set; }
    }
}
