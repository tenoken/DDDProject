using DDDProject.Domain.Entities;
using System.Collections.Generic;

namespace DDDProject.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
