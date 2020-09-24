using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Citizen : IPerson, IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public Citizen(string id, string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
