using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPerson
    {
        string Name
        {
            get;
            set;
        }

        int Age
        {
            get;
            set;
        }
    }
}
