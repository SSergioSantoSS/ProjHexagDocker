using ProjHexag.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHexag.Domain.Ports.Repositories
{
    internal interface IServicoRepository : IBaseRepository<Servico, Guid>
    {
    }
}
