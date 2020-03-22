using DDDProject.Domain.Entities;
using System.Collections.Generic;

namespace DDDProject.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
