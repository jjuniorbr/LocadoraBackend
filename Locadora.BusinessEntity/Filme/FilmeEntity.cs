using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.BusinessEntity.Filme
{
    public class FilmeEntity
    {
        public FilmeEntity() { }
        public FilmeEntity(int id, string nome, FichaTecnicaEntity fichaTecnica = default)
        {
            Id = id;
            Nome = nome;
            FichaTecnica = fichaTecnica;
        }
        public int Id { get; }
        public string Nome { get; }
        public FichaTecnicaEntity FichaTecnica { get; }
        public bool Ativo { get; set; }
    }
}