using Locadora.BusinessEntity.Locacao;
using Locadora.DataAccess.Locacao;
using System;

namespace Locadora.BusinessLogic.Locacao
{
    public class LocacaoBusinessLogic
    {
        private readonly LocacaoDao _locacaoDao;

        public LocacaoBusinessLogic()
        {
            _locacaoDao = new LocacaoDao();
        }
        public LocacaoEntity IncluirLocacao(LocacaoEntity locacao)
        {
            if (ValidarDisponibilidadeDeFilmePorId(locacao.Filme.Id))
                throw new Exception("Este Filme não está disponível para Locação");
                        
            return _locacaoDao.IncluirLocacao(locacao);
        }

        public LocacaoEntity ObterLocacaoPorId(int idLocacao)
        {
            return _locacaoDao.ObterLocacaoPorId(idLocacao);
        }
        public LocacaoEntity DevolverLocacao(LocacaoEntity locacao)
        {
            LocacaoEntity _locacao = ObterLocacaoPorId(locacao.Id);

            if ((_locacao.DataLocacao - _locacao.DataLocacao).TotalDays > 5)
                throw new Exception("Filme com devolução em atraso, esta operação deverá ser feita pelo Módulo X.");
            
            return _locacaoDao.DevolverLocacao(locacao);
        }
        
        public bool ValidarDisponibilidadeDeFilmePorId(int id)
        {
            return _locacaoDao.ValidarDisponibilidadeDeFilmePorId(id);
        }
    }
}