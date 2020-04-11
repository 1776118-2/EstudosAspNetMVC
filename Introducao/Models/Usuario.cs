using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class Usuario
    {        
        public string Nome { get; set; }
        public string Observacoes { get; set; }
        public int Idade { get; set; }
        public String Email { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public String ConfirmarSenha { get; set; }
    }
}