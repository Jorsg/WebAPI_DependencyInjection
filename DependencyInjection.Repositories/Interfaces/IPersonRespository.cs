using DependencyInjection.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DependencyInjection.Repositories.Interfaces {
    public interface IPersonRespository {

        Task<Person> GetPerson();
        Task<Person> GetPersonbyId(int id);
    }
}
