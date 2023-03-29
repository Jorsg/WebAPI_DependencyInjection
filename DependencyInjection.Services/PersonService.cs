using DependencyInjection.Common.Models;
using DependencyInjection.Repositories.Interfaces;
using DependencyInjection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services {
    public class PersonService : IPersonService {

        private readonly IPersonRespository _personRepo;

        public PersonService(IPersonRespository personRepo) {
            _personRepo = personRepo ?? throw new ArgumentNullException(nameof(personRepo));
        }

        public Task<Person> GetPerson() {
            
            return _personRepo.GetPerson();
        }

        public Task<Person> GetPersonById(int id) {

            return _personRepo.GetPersonbyId(id);
        }
    }
}
