using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.BusinessEntity.Filme
{
    public class FichaTecnicaEntity
    {
        public FichaTecnicaEntity() { }

        public int Id { get; }
        public FilmeEntity Filme { get; }

        public string Diretor { get; }
        public int AnoLancamento { get; }
        public string Produtora { get; }
    }
}
