using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Locadora.BusinessEntity.Cliente;
using Locadora.BusinessLogic.Cliente;
using Locadora.BusinessEntity.Filme;
using Locadora.BusinessLogic.Filme;
using Locadora.BusinessEntity.Locacao;
using Locadora.BusinessLogic.Locacao;

namespace Locadora.Web.Api.Controllers
{
    [RoutePrefix("api/Locadora")]
    public class LocadoraController : ApiController
    {
        private readonly ClienteBusinessLogic _clienteBusinesslogic;
        private readonly FilmeBusinesslogic _filmeBusinesslogic;
        private readonly LocacaoBusinessLogic _locacaoBusinessLogic;

        public LocadoraController()
        {
            _clienteBusinesslogic = new ClienteBusinessLogic();
            _filmeBusinesslogic = new FilmeBusinesslogic();
            _locacaoBusinessLogic = new LocacaoBusinessLogic();
        }

        /// <summary>
        /// Realiza o Cadastro de um novo Cliente
        /// </summary>
        /// <param name="request">Estrutura contendo os Dados do Cliente </param>
        /// <returns></returns>
        [HttpPost, Route("IncluirCliente")]
        public async Task<IHttpActionResult> IncluirCliente([FromBody]ClienteEntity request)
        {
            var response = _clienteBusinesslogic.IncluirCliente(request);
            return Ok(response);

        }

        /// <summary>
        /// Consulta o Cadastro de um Cliente a partir do Número do CPF
        /// </summary>
        /// <param name="cpf">CPF do Cliente para pesquisa</param>
        /// <returns></returns>
        [HttpGet, Route("{cpf}/ObterClientePorCPF")]
        public async Task<IHttpActionResult> ObterClientePorCPF(string cpf)
        {
            var response = _clienteBusinesslogic.ObterClientePorCPF(cpf);
            return Ok(response);

        }

        /// <summary>
        /// inativa o Cadastro do Cliente, exclusão lógica
        /// </summary>
        /// <param name="cpf">Número do CPf do Cliente</param>
        /// <returns></returns>
        [HttpPost, Route("{cpf}/InativarClientePorCPF")]
        public async Task<IHttpActionResult> InativarClientePorCPF(string cpf)
        {
            var response = _clienteBusinesslogic.InativarClientePorCPF(cpf);
            return Ok(response);

        }

        /// <summary>
        /// Cadastro de um novo Filme
        /// </summary>
        /// <param name="request">Dados do Filme</param>
        /// <returns></returns>
        [HttpPost, Route("IncluirFilme")]
        public async Task<IHttpActionResult> IncluirFilme([FromBody]FilmeEntity request)
        {
            var response = _filmeBusinesslogic.IncluirFilme(request);
            return Ok(response);

        }
                
        /// <summary>
        /// Inativa um filme cadastro / exclusão lógica
        /// </summary>
        /// <param name="id">ID do Filme</param>
        /// <returns></returns>
        [HttpPost, Route("InativarFilmePorid")]
        public async Task<IHttpActionResult> InativarFilmePorId(int id)
        {
            var response = _filmeBusinesslogic.InativarFilmePorId(id);
            return Ok(response);

        }

        /// <summary>
        /// Efetiva o movimento de locação de um Filme
        /// </summary>
        /// <param name="request">Dados da locação</param>
        /// <returns></returns>
        [HttpPost, Route("IncluirLocacao")]
        public async Task<IHttpActionResult> IncluirLocacao([FromBody]LocacaoEntity request)
        {
            var response = _locacaoBusinessLogic.IncluirLocacao(request);
            return Ok(response);

        }

        /// <summary>
        /// Efetiva a devolução do Filme que foi locado
        /// </summary>
        /// <param name="request">Dados da Locação</param>
        /// <returns></returns>
        [HttpPost, Route("DevolverLocacao")]
        public async Task<IHttpActionResult> DevolverLocacao([FromBody]LocacaoEntity request)
        {
            var response = _locacaoBusinessLogic.DevolverLocacao(request);
            return Ok(response);

        }
    }
}
