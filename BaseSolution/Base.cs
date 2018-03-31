using System;

namespace BaseSolution
{
    public class Base : IBase
    {
        public String Title { get; set; }
        public String Comments { get; set; }
        public int Id { get { return Id; } set => Id = value; }
        public bool Removed { get { return Removed; } set => Removed = value; }

        public void Print()
        {
            throw new NotImplementedException();
        }
        public bool SetRemoved(Object o) { return true; }
    }
}
