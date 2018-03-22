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
        public static List<Person> persons = new List<Person>();
        public static Person GetPerson(String email) => persons.Find(person => person.Email == email);
        public static void SetPerson(Person p) => persons.Add(p);
        public bool SetRemoved(Person p) => persons.Remove(p);
    }
}
