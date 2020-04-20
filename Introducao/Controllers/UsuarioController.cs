using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {       
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }
        
        //VALIDAÇÂO DE USUÁRIO
        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {   //forma de validação para casos simples!
            ////Exemplo 1 de validação:
            //if(string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            //}

            ////Exemplo 2 de validação:
            //if(usuario.Senha != usuario.ConfirmarSenha)
            //{
            //    //Não coloca nome de propriedade, pois o validateSumary gera a msg de erro automático
            //    ModelState.AddModelError("", "As senhas são diferentes");
            //}



            if(ModelState.IsValid)
            {
                //Se o usuario for válido redireciona para a View
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(String login)
        {
            //Banco de dados fictício com 3 registros
            var bdExemplo = new Collection<string>
            {
                "Rodrigo",
                "Silva",
                "Santos"
            };
            //se o registro for diferente que o usuário inserir
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}