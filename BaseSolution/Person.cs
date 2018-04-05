using System;
using System.Collections.Generic;
using System.Text;
namespace BaseSolution
{
    public class Person: Base
    {
        public DateTime BirthDate { get; set; }
        public String FatherName;
        public String Email { get; set; }
       
        public Person CreatePersons() {
            Person p = new Person();
            Console.Write("Email: ");
            p.Email = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Data de nascimento: ");
            p.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Nome do pai: ");
            p.FatherName = Console.ReadLine();
            return p;
        }
    }
}
