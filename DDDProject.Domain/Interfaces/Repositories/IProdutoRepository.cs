using DDDProject.Domain.Entities;
using System.Collections.Generic;

namespace DDDProject.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
