using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jingga",19);
            
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Rico",35,"3445","komdat");
            
            teacher.GetNameAndAge();

            Student student = new Student("Jeje",23,"6666","jeje@y.c");
         
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
