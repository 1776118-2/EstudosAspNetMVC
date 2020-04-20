using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {   
        //Exemplos de Validação na cs
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres" )]
        public string Observacoes { get; set; }

        //Exemplo de validação com Range :
        [Range(18,70, ErrorMessage = "A sua idade tem que estar entre 18 e70 anos")]
        public int Idade { get; set; }
        
        //Exemplo de validação com RegularExpression
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um e-mail válido")]
        public String Email { get; set; }

        //validações do login
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 à 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe.")]
        public String Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório")]
        public String Senha { get; set; }

        //Exemplo de comparação de senha
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="As senhas não se coincidem")]
        public String ConfirmarSenha { get; set; }
    }
}