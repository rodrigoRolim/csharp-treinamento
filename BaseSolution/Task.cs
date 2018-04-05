using System;

namespace BaseSolution {

    public class Task: Base {
        public Person Responsible {get; set;} 
        public Decimal WorkHours {get; set;}
        public enum ETaskType {
            CODIFICATION, TEST_CASE, BUG
        }
       public  ETaskType? valor;

       public  Task CreateTasks() {
            Task t = new Task();
            Console.WriteLine("Cadastro do responsável: ");
            Console.WriteLine("\n");
            t.Responsible =  Responsible.CreatePersons();
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