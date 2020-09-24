using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Robot: IIdentifiable
    {
        private string model = "";
        public string Id { get; set; }

        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

    }
}
