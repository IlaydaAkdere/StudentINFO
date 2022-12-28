using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem.Dtos
{
    public class StudentListDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }
    }
}
//entities kullanmıyoruz her zaman dırek Db tablosuna gıttıgı için oyzuden Dto olarak sanal bir tablo olusturuyoruz 
// her işlem için ayrı Dto olusturuyoruz.
//MAP- entities ile Dto baglamak için kullanılır.
