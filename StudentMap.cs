using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInfoSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace StudentInfoSystem.Mappings
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.FirstName).HasColumnName("FirstName");
            builder.Property(s => s.LastName).HasColumnName("LastName");
            builder.Property(s => s.StudentNumber).HasColumnName("StudentNumber");
            builder.Property(s => s.Age).HasColumnName("Age");

            builder.HasData(new List<Student>
            {
                new Student {FirstName = "ilayda", LastName = "Akdere" , StudentNumber = 316 ,  Age = 22},
                new Student {FirstName = "aykut", LastName = "Ozturk" , StudentNumber = 316 ,  Age = 22},
                new Student {FirstName = "oguzhan", LastName = "atmaca" , StudentNumber = 316 ,  Age = 22},
                new Student {FirstName = "szymon", LastName = "Moytka" , StudentNumber = 316 ,  Age = 22},
                new Student {FirstName = "erwinio", LastName = "Czernecki" , StudentNumber = 316 ,  Age = 22},
                new Student {FirstName = "emıne", LastName = "Mete" , StudentNumber = 316 ,  Age = 22}
            });
        }
    }
}
//IEntityTypeConfiguration - configuratıon a ulasmak için yaptık entitiesdeki tüm tabloların alanlarına ulasıp bılgıelrını ayarlamak için kullanırız.