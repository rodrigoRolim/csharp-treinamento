using System;
using BaseSolution;
namespace ConsoleApp1
{
    class Program
    {
        public static Project BusinessProject = new Project();
        public static void PrintProject() => BusinessProject.Print();
        public static void AddProject(Project p) => BusinessProject.SetProject(p);
        public static void FinishProject() => BusinessProject.MarkFinished();
        public static bool RemoveProject(Project p) => BusinessProject.SetRemoved(p);
        static void Main(string[] args)
        {
            String itemMenu = Console.ReadLine();
            if(itemMenu == "1")
            {
                Console.WriteLine("Escolha uma ação: ");
                Console.WriteLine("1 para add Projeto");
                Console.WriteLine("2 para excluir projeto existente");

                String option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Project project = new Project
                        {
                            Code = Console.ReadLine(),
                            Title = Console.ReadLine(),
                            Comments = Console.ReadLine()
                        out };
                        DateTime date;
                        DateTime.TryParse(Console.ReadLine(), out date);
                        project.StartDate = date;
                        DateTime.TryParse(Console.ReadLine(), out date);
                        project.RealEndDate = date;
                        DateTime.TryParse(Console.ReadLine(), out date);
                        project.EstimatedEndDate = date;
                        Console.WriteLine("adcionar colaboradores");
                      //  project.responsible.Email = Console.ReadLine();
                        Program.AddProject(project);
                        break;
                    case "2":

                        break;
                }
            }
            if (itemMenu == "2")
            {
                Console.WriteLine("Escolha uma ação: ");
                Console.WriteLine("1 para add project");
                Console.WriteLine("2 para excluir project existente");
                Console.WriteLine("3 para finalizar um project");

                String option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        addProject();
                }
            }
        }
       
    }
}
