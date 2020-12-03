using Locadora.BusinessEntity.Filme;
using Locadora.DataAccess.Filme;

namespace Locadora.BusinessLogic.Filme
{
    public class FilmeBusinesslogic
    {
        private readonly FilmeDao _filmeDao;

        public FilmeBusinesslogic()
        {
            _filmeDao = new FilmeDao();
        }
        public FilmeEntity IncluirFilme(FilmeEntity filme)
        {
            return _filmeDao.IncluirFilme(filme);
        }
        public FilmeEntity ObterFilmePorId(int idFilme)
        {
            return _filmeDao.ObterFilmePorId(idFilme);
        }
        public FilmeEntity InativarFilmePorId(int idFilme)
        {
            return _filmeDao.InativarFilmePorId(idFilme);
        }
    }
}