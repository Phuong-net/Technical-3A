/*
   Author: Phuong Nguyen
  Date: 09/21/2020
  Comment: a.  Ask the User to enter their name.
           b. Write a Method that prints to the Console:  "Hello user's name (insert real name)
*/
using System;

namespace Technical_3A
{
    class Program
    {
        static void MyName()
        {
            Console.WriteLine("Please enter your name");
        }
        static void Main(string[] args)
        {   //Asking users' name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            {
                Console.WriteLine(" The program enter your name.");
                Console.WriteLine("Press any keys to exit the program and try again...");
                Console.ReadKey(true);
            }
        }

    }
}
