using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSolution
{
    interface IBase
    {
        Int32 Id { get; set; }
        Boolean Removed { get; set; }
        void Print();
    }
}
