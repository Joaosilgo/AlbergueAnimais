using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbergueAnimais.Models
{
    public class Utilizador : IdentityUser
    {
        public string UtilizadorID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DBO { get; set; }
        public string Morada { get; set; }
        public string Genero { get; set; }

        public string Cargo { get; set; }
    }
}
