using DependencyInjection.Common.Models;
using DependencyInjection.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Repositories {
    public class PersonRepository : IPersonRespository {


        public PersonRepository() {
        }

        public async Task<Person> GetPerson() {

            var person = new Person();
            person.FullName = "Jorman Garcia";
            person.Id = 13123131;

            return person;
        }

        public async Task<Person> GetPersonbyId(int id) {

            var person = new Person();
            if (id > 0) {
                person.FullName = "Jorman Garcia";
                person.Id = id;
            }
            return person;
        }
    }
}
