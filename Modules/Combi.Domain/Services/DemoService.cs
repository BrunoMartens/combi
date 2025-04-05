using AutoMapper;
using Combi.Dal.Repositories.Interfaces;
using Combi.Domain.Entities;
using Combi.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi.Domain.Services
{
    public class DemoService: IDemoService
    {
        private readonly IMapper _mapper;
        private readonly IDemoRepository _demoRepository;

        public DemoService(
            IMapper mapper,
            IDemoRepository demoRepository)
        {
            _mapper = mapper;
            _demoRepository = demoRepository;
        }

        public IEnumerable<Demo> GetAll()
        {
            return _mapper.Map<IEnumerable<Demo>>(_demoRepository.GetAll());
        }
    }
}
