using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Process
    {
        public static void Run()
        {
            string Stop = "";
   

            List<IIdentifiable> listID = new List<IIdentifiable>();
            do
            {
                Console.WriteLine("Please, input Name, age, id for Person");
                Console.WriteLine("Input Model, ID for Robot");
                var input = Console.ReadLine().Split();
                if (input.Length == 03)
                {
                    IIdentifiable citizen = new Citizen(input[2], input[0], Int32.Parse(input[1]));
                    listID.Add(citizen);
                }
                else if (input.Length == 2)
                {
                    IIdentifiable robot = new Robot(input[1], input[0]);
                    listID.Add(robot);
                }
                else Console.WriteLine("Invalid Data, Too many data");

                Console.WriteLine("do you want to input one more object");
                Stop = Console.ReadLine();
                   
            }
            while (Stop != "End");

            Console.WriteLine("Pls input invalid ID");
            string invalidID = Console.ReadLine();

            int count = 0;
            List<string> invalidIDList = new List<string>();
            foreach(IIdentifiable value in listID)
            {
                if (invalidID.Length <= value.Id.Length)
                {
                    if (value.Id.EndsWith(invalidID))
                    {
                        count++;
                        invalidIDList.Add(value.Id);
                    }
                }
            }

            if (count > 0)
            {
                int i = 0;
                foreach (string value in invalidIDList)
                {
                    i += 1;
                    Console.WriteLine(i.ToString() + ": "  + value);
                }
            }
            else Console.WriteLine("<empty output>");

            Console.ReadLine();
        }
    }
}
