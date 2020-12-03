using Locadora.BusinessEntity.Filme;
using Locadora.DataAccess.Resources.Database;

namespace Locadora.DataAccess.Filme
{
    public class FilmeDao
    {
        public FilmeEntity IncluirFilme(FilmeEntity filme)
        {
            return Filmes.IncluirFilme(filme);
        }
        public FilmeEntity ObterFilmePorId(int idFilme)
        {
            return Filmes.ObterFilmePorId(idFilme);
        }
        public FilmeEntity InativarFilmePorId(int idFilme)
        {
            return Filmes.InativarFilmePorId(idFilme);
        }
    }
}