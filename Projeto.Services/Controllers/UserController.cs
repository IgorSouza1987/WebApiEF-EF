using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Projeto.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Projeto.Services.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(UserCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User user = new User();
                    user.Nome = model.Nome;
                    user.Email = model.Email;
                    user.Senha = model.Senha;
                    user.SenhaConfirm = model.SenhaConfirm;


                    UserRepository repository = new UserRepository();
                    repository.Inserir(user);

                    return Request.CreateResponse(HttpStatusCode.OK, "Aluno cadastrado com sucesso");
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Ocorreram erros de validação");
            }
        }
    }
}
