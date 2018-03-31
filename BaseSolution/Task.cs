using System;

namespace BaseSolution {

    public class Task: Base {
        public Person Responsible {get; set;} 
        public Decimal WorkHours {get; set;}
        public enum ETaskType {
            CODIFICATION, TEST_CASE, BUG
        }
       public  ETaskType? valor;
    }
}