using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;
using System.Text.Json;
using Infrastructure.Persistence.Dto;
using Infrastructure.Persistence.Mappers;

namespace Infrastructure.Persistence.Repositories
{
    public class AdopterJsonRepo : IModelRepository<Adopter>
    {
        List<Adopter> _cache = new List<Adopter>();
        string _filePath = "adopters.json";
        public void EnsureLoaded()
        {
            if (_cache.Count > 0) return;
            if (!File.Exists(_filePath))
            {
                // file mancante -> cache vuota (già inizializzata)
                return;
            }
            _cache = JsonSerializer.Deserialize<List<AdopterPercistenceDto>>(File.ReadAllText(_filePath))!.Select(dto => dto.ToEntity()).ToList();
             
            //manca il dto e il mapper
        }
        public void AddToRepo(Adopter itemToAdd) 
        {
            EnsureLoaded();
            _cache.Add(itemToAdd);Queryable
        }

        public IEnumerable<Adopter> GetAll()
        {
            EnsureLoaded();
        }

        public void RemoveFromRepo(Adopter itemToRemove)
        {
            throw new NotImplementedException();
        }

        public void Update(Adopter itemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
