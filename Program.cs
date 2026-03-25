using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {

        public string Name { get; set; } = "No Student added yet";
        public int Age { get; set; } = -1;
        public void Header() {
            //Create a Header for our Application
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========================================================");
            Console.WriteLine("                     STUDENT SYSTEM                     ");
            Console.WriteLine("========================================================");
            Console.WriteLine("                 Welcome to Student System               ");
            Console.ResetColor();
        }
        public void Menu()
        {
            //Menu
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Select an option ");

        }
        public void AddStudent() {
            Console.WriteLine("Enter student name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter student age : ");
            Age = Convert.ToInt32(Console.ReadLine());


        }

        public void ViewStudent() {
            Console.WriteLine($"Student Name is {Name} and age {Age}");
        }




        static void Main(string[] args)
        {
            

            Program ob = new Program();
            ob.Header();
            ob.Menu();
            int option = Convert.ToInt32(Console.ReadLine());
            //Keep program running until the user selects Exit
            bool term = true;
            while (term)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add Student Selected");
                        //Console.ReadKey();
                        ob.AddStudent();
                        ob.Menu();
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("View Student Selected");
                        //Console.ReadKey();
                        ob.ViewStudent();
                        ob.Menu();
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Exit Selected");
                        //Console.ReadKey();
                        term = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        
                        break;

                }
               
            }

        }
    }
}
