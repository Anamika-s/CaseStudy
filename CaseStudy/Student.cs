using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Student() {}

        public Student(int id, string name , DateTime dateOfBirth)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }


        
    }

    class info
    {
        //public void Display(Student student)
        //{
        //    //foreach (var temp in student)
        //    //{
        //    Console.WriteLine(student.id);
        //    Console.WriteLine(student.name);
        //    Console.WriteLine(student.dateOfBirth);
        //    // }
        //}
        public void Display(params Student[] student)
        {
            foreach (var temp in student)
            {
                Console.WriteLine(temp.id);
                Console.WriteLine(temp.name);
                Console.WriteLine(temp.dateOfBirth);
            }
        }
    }
}
