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
        public void BuildAddPersons() => AddPerson(BuildPersons());
        public void SetRemoved(Project p) {Console.WriteLine("remover");}
        public bool MarkFinished() => active = false;
        private void BuildProject() {
            
            Console.WriteLine("Cadastro do projeto");
            Console.Write("Codigo: ");
            Code = Console.ReadLine();
            
        }
        private Person BuildPersons() {
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
        public void BuildAddTasks() => AddTask(BuildTasks());
        private Task BuildTasks() {
            Task t = new Task();
            Console.WriteLine("Cadastro do responsável: ");
            Console.WriteLine("\n");
            t.Responsible =  BuildPersons();
            Console.Write("\n");
            Console.Write("Horas de trabalho: ");
            t.WorkHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Selecione: 1-BUG, 2-CODIFICATION, 3-TEST_CASE");
            Int32 opcao = Convert.ToInt32(Console.Read());
            switch(opcao) {
                case 1:
                    t.valor = Task.ETaskType.BUG;
                    break;
                case 2:
                    t.valor = Task.ETaskType.CODIFICATION;
                    break;
                case 3:
                    t.valor = Task.ETaskType.TEST_CASE;
                    break;
                default:
                    Console.WriteLine("Valor inválido, tente novamente");
                    break;
            }
            return t;
        }
    }
}

