using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSolution
{
    public class Project: Base
    {
        public String Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime RealEndDate { get; set; }
        private List<Person> responsible = new List<Person>();
        public static List<Project> Projects;
        public Boolean active;
        public Project()
        {
            Projects = new List<Project>();
        }
        public static Project GetProject(String code) => Projects.Find(project => project.Code == code);
        public void SetProject(Project p) => Projects.Add(p);
        public void InitPersons()
        {
            Person p = new Person();
            p.Email = Console.ReadLine();
            DateTime.TryParse(Console.ReadLine(), out DateTime date);
            p.BirthDate = date;
            p.FatherName = Console.ReadLine();
            Person.SetPerson(p);
        }
        public bool SetRemoved(Project p) => Projects.Remove(p);
        public bool MarkFinished() => active = false;
        public DateTime GetNowDateTime => DateTime.Now;
        public new void Print()
        {
            foreach (Project p in Projects)
            {
                Console.WriteLine("Code: " + p.Code);
                Console.WriteLine("Start Data: " + p.StartDate);
                Console.WriteLine("Estimated Data" + p.EstimatedEndDate);
                Console.WriteLine("End Data" + p.RealEndDate);
               // Console.WriteLine("Responsible: " + p.responsible.Email);
            }
        }

    }
}

