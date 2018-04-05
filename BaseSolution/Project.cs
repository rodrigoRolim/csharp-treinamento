using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSolution
{
    public class Project: Base
    {
        public Task Task { get; set;}
        public Person Person { get; set; }
        public String Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime realEndDate;
        public DateTime RealEndDate { 
            get{
                return realEndDate;
            } 
            set{
                realEndDate = value == null ? DateTime.Now : value;
            }
        }
        private List<Person> Users;
        private List<Task> Tasks;
        public Boolean active = true;
        public Project()
        {
            this.Users = new List<Person>();
            this.Tasks = new List<Task>();
        }
        private void AddPerson(Person p) => Users.Add(p);
        private void AddTask(Task t) => Tasks.Add(t);
        public void BuildAddTasks() => AddTask(Task.CreateTasks());
        public void BuildAddPersons() => AddPerson(Person.CreatePersons());
        public void SetRemoved(Project p) {Console.WriteLine("remover");}
        public bool MarkFinished() => active = false;
        public void ListTasks() {
            Tasks.ForEach(tasks => {
                Console.WriteLine(tasks.Responsible);
                Console.WriteLine(tasks.WorkHours);
            });
        }  
        private void CreateProject() {
            Console.WriteLine("Cadastro do projeto");
            Console.Write("Codigo: ");
            Console.Write("\n");
            Code = Console.ReadLine();
            Console.Write("Data inicial: ");
            StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Data final estimada:");
            EstimatedEndDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Data final real: ");
            realEndDate = Convert.ToDateTime(Console.ReadLine());
        }
        public void BuildProject() {
            CreateProject();
            Console.Clear();
            BuildAddPersons();
            Console.Clear();
            BuildAddTasks();
        }
    }
}

