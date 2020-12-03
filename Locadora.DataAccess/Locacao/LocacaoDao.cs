using Locadora.BusinessEntity.Locacao;
using Locadora.DataAccess.Resources.Database;

namespace Locadora.DataAccess.Locacao
{
    public class LocacaoDao
    {
        public LocacaoEntity IncluirLocacao(LocacaoEntity locacao)
        {
            return Locacoes.IncluirLocacao(locacao);
        }
        public LocacaoEntity ObterLocacaoPorId(int idLocacao)
        {
            return Locacoes.ObterlocacaoPorId(idLocacao);
        }
        public LocacaoEntity DevolverLocacao(LocacaoEntity locacao)
        {
            return Locacoes.DevolverLocacao(locacao);
        }
        
        public bool ValidarDisponibilidadeDeFilmePorId(int id)
        {
            return Locacoes.ValidarDisponibilidadeDeFilmePorId(id);
        }
    }
}