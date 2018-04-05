using System;
using System.Collections.Generic;

namespace BaseSolution
{
    public class FactoryProjects {
        List<Project> Projects; 
        Task Task {get; set;}
        Person User {get; set;}
        Project Project {get; set;}
        public FactoryProjects() {
            
        }
        public void StartFactoryProjects() {
           
           Console.WriteLine("Opções de menu: ");
           Console.WriteLine("1-Criar lista");
           Console.WriteLine("2-Listar o Projeto com os usuários e as tarefas");
           Console.WriteLine("0-finalizar programa");

           var entrada = Convert.ToInt32(Console.ReadLine());
           switch(entrada){
               case 1:
                    Project Project = new Project();
                    Project.BuildProject();
                    Projects.Add(Project);
                break;
                case 2:
                    Projects.ForEach(x => Console.WriteLine(x));
                    break;
           }
        }
    }    
}