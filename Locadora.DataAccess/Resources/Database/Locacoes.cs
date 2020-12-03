using Locadora.BusinessEntity.Locacao;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Locadora.DataAccess.Resources.Database
{
    static class Locacoes
    {
        public static List<LocacaoEntity> _Locacoes;

        static Locacoes() { _Locacoes = new List<LocacaoEntity>(); }

        public static LocacaoEntity IncluirLocacao(LocacaoEntity locacao)
        {
            _Locacoes.Add(new LocacaoEntity(locacao.Id, locacao.Cliente, locacao.Filme, locacao.DataLocacao, locacao.DataDevolucao, locacao.Valor));
            
            return _Locacoes.LastOrDefault();
        }

        public static LocacaoEntity ObterlocacaoPorId(int idLocacao)
        {
            var _locacoes = _Locacoes.Where(locacoes => locacoes.Id.Equals(idLocacao)).FirstOrDefault();
            return _locacoes;
        }

        public static LocacaoEntity DevolverLocacao(LocacaoEntity locacao)
        {
            var _locacao = _Locacoes.FirstOrDefault(reg => reg.Id.Equals(locacao.Id));
            _locacao.DataDevolucao = DateTime.Today;
            return _locacao;
        }

        public static bool ValidarDisponibilidadeDeFilmePorId(int id)
        {
            var _locacao = _Locacoes.FirstOrDefault(reg => reg.Id.Equals(id));

            return Convert.ToBoolean(_locacao.DataDevolucao);
        }
    }
}