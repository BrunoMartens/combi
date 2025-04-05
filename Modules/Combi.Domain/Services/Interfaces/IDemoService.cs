using Combi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi.Domain.Services.Interfaces
{
    public interface IDemoService
    {
        IEnumerable<Demo> GetAll();
    }
}
