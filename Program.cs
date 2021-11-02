using System;
using Persona;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            Person johan = new Person("Johan", "Liebert", "", 20, "blue");

            
            Console.WriteLine(johan);
            
            
            Console.WriteLine("I can have breakfast/go to school\nto close write: end ");
            string choice = Console.ReadLine();
            bool flag = true;
            while (flag) {
                if (choice == "end")
                {
                    flag = false;
                }
                else
                {
                    if (choice == "breakfast")
                    {
                        johan.eatBreakfast();
                        choice = Console.ReadLine();
                    }
                    else if (choice == "school")
                    {
                        johan.goInSchool();
                        choice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("I can't understand");
                        choice = Console.ReadLine();
                    }
                }  
            }
        }
    }
}
