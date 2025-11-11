using Application.Dto;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class SexMapper
    {
        public static bool ToEntity(this SexDto dto )
        {
            if (dto.Sex.ToLower() == "male")
            {
                return true;
            }
            return false;
        }
        public static SexDto ToDto(this bool value){
            if (value == true)
            {
                return new SexDto("male");
            }
            return new SexDto("female");
        }
    }
}
