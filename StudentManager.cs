using StudentInfoSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace StudentInfoSystem.Managers
{
    public class StudentManagerApplicationService
    {
        private readonly IRepository<Student, int> _userRepository;
        public StudentManagerApplicationService(IRepository<Student, int> userRepository)
        {
            _userRepository = userRepository;
        }

        // işlemler buraya

    }
}

// studentmanager ı application service olarak türettik.
// IRepository abp den gelıyor.
//Readonly sadece okuanbılır burada
//Dto -data transfer object
// migration için connettion string e ihtiyacımız var connection string Db info kapsar