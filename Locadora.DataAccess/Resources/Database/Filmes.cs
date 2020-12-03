using Locadora.BusinessEntity.Filme;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.DataAccess.Resources.Database
{
    static class Filmes
    {
        public static List<FilmeEntity> _Filmes;

        static Filmes() { _Filmes = new List<FilmeEntity>(); }

        public static FilmeEntity IncluirFilme(FilmeEntity filme)
        {
            _Filmes.Add(new FilmeEntity(filme.Id,filme.Nome));
            return _Filmes.LastOrDefault();
        }

        public static FilmeEntity ObterFilmePorId(int idFilme)
        {
            var _filme = _Filmes.Where(film => film.Id.Equals(idFilme)).FirstOrDefault();
            return _filme;
        }

        public static FilmeEntity InativarFilmePorId(int idFilme)
        {
            var _filme   = _Filmes.FirstOrDefault(film => film.Id.Equals(idFilme));
            _filme.Ativo = false;

            return _filme;
        }
    }
}