using DDDProject.Domain.Entities;
using System.Collections.Generic;

namespace DDDProject.Domain.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
