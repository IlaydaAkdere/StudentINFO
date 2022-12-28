using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace StudentInfoSystem.Entities
{
    public class Student : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }

        public int Age { get; set; }
    
    }

}

// Domain bazı mımarılerde entities olarak görundugunden onun içine koyarız.