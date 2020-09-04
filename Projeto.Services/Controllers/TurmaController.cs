using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Projeto.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/Turma")]
    public class TurmaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(TurmaCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Turma turma = new Turma();
                    turma.Codigo = model.Codigo;

                    TurmaRepository repository = new TurmaRepository();
                    repository.Inserir(turma);

                    return Request.CreateResponse(HttpStatusCode.OK, "Turma cadastrada com sucesso");
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


        [HttpPut]
        public HttpResponseMessage Put(TurmaEdicaoModel model)
        {
            if (ModelState.IsValid)
            //verifica se os campos passaram nas validações
            {
                try
                {
                    Turma turma = new Turma();
                    turma.IdTurma = model.IdTurma;
                    turma.Codigo = model.Codigo;

                    TurmaRepository repository = new TurmaRepository();

                    repository.Alterar(turma);
                    return Request.CreateResponse(HttpStatusCode.OK, "Turma acaba de ser atualizado com sucessso.");
                }
                catch (Exception e)
                {
                    
                    return Request.CreateResponse
                   (HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Ocorreram erros de validação.");
            }
        }


        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            
            try
            {
                
                TurmaRepository repository = new TurmaRepository();
                Turma turma = repository.ObterPorId(id);
                
                    repository.Excluir(turma);

                return Request.CreateResponse(HttpStatusCode.OK,"Turma excluída com sucesso.");
            }
            catch (Exception e)
            {
                return Request.CreateResponse
                (HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<TurmaConsultaModel> lista = new List<TurmaConsultaModel>();
                
                TurmaRepository repository = new TurmaRepository();

                foreach (var item in repository.ObterTodos())
                {
                    TurmaConsultaModel model = new TurmaConsultaModel();

                    model.IdTurma = item.IdTurma;
                    model.Codigo = item.Codigo;
                   
                    
                    
                    lista.Add(model); 
                }
                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {

                return Request.CreateResponse (HttpStatusCode.InternalServerError, e.Message);

            }
        }



    }
}
