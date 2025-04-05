using AutoMapper;
using Combi.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi.Domain.Configuration
{
    public class AutoMapperDomainProfile: Profile
    {
        public AutoMapperDomainProfile()
        {
            InitMaps();
        }

        private void InitMaps()
        {
            CreateMap<Demo, Entities.Demo>();
        }
    }
}
