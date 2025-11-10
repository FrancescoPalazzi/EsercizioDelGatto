using Application.Dto;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infgrastructure.Persistence.Mappers
{
    public static class SexMapper
    {
        public static Sex ToEntity(this SexDto dto)
        {
            if (dto.Sex == 0)
            {
                return Sex.Male;
            }
            return Sex.Female;
        }
        public static SexDto ToDto(this Sex value)
        {
            if (value == Sex.Male)
            {
                return new SexDto(0);
            }
            return new SexDto(1);
        }
    }
}
