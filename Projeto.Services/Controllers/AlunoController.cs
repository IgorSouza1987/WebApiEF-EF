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
    [RoutePrefix("api/Aluno")]
    public class AlunoController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(AlunoCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Aluno aluno = new Aluno();
                    aluno.Nome = model.Nome;
                    aluno.Matricula = model.Matricula;
                    aluno.Email = model.Email;
                    aluno.IdTurma = model.IdTurma;


                    AlunoRepository repository = new AlunoRepository();
                    repository.Inserir(aluno);

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

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                AlunoRepository repository = new AlunoRepository();
                Aluno aluno = repository.ObterPorId(id);

                repository.Excluir(aluno);
                
               

                return Request.CreateResponse(HttpStatusCode.OK, "Excluido com sucesso");
            }
            catch (Exception e )
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPut]
        public HttpResponseMessage Put (AlunoEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Aluno aluno = new Aluno();

                    aluno.IdAluno = model.IdAluno;
                    aluno.Nome = model.Nome;
                    aluno.Matricula = model.Matricula;
                    aluno.Email = model.Email;
                    aluno.IdTurma = model.IdTurma;

                    AlunoRepository repository = new AlunoRepository();
                    repository.Alterar(aluno);

                    return Request.CreateResponse(HttpStatusCode.OK, "Atualizado com sucesso!");

                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
               
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Erros de Validação");
            }
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<AlunoConsultaModel> lista = new List<AlunoConsultaModel>();

                AlunoRepository repository = new AlunoRepository();
                foreach (var item in repository.ObterTodos()) 
                {
                    AlunoConsultaModel model = new AlunoConsultaModel();
                    
                    model.IdAluno = item.IdAluno;
                    model.Nome = item.Nome;
                    model.Matricula = item.Matricula;
                    model.Email = item.Email;
                    model.IdTurma = item.IdTurma;

                    lista.Add(model);
                }
                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
