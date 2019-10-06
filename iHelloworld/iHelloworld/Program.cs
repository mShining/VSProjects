using System;

namespace iHelloworld
{
    class Program
    {
        static void Main(string[] args)
        {

            Program myProgram = new Program();
            myProgram.Print();

            PrintBlankLine();
            Console.WriteLine("Why don't you tell me your name?");
            string name = Console.ReadLine(); // get read from console input
            Console.WriteLine("Hey, " + name + "!"); // the way of combining normal words with variables (Like the Java style)
            Console.WriteLine($"Now I know your name is {name}."); // another way

            PrintBlankLine();
            Console.WriteLine("======== Tutorial 7 ========");
            //Tutorial 7
            /*
             * variable - stores some value
             * identifier = what we call the variable
             * expression - evaluates to a value
             * operator - it works on operands
             * operand - the thing(s) the operator works on
            */
            int x = 5;
            var y = 5.0; // var could let the compiler infers out the type automatically      
            string s = "Caleb";
            Console.WriteLine(s + " is weird.");

            PrintBlankLine();
            Console.WriteLine("======== Tutorial 8 ========");
            //Tutorial 8
            /*
             * 
            */
            int x1 = 5;
            int? y1 = null;
            Console.WriteLine(y1);




            Console.ReadKey();
        }

        void Print()
        {
            Console.WriteLine("Hello World!");
            PrintBlankLine();
            System.Console.WriteLine("Hello, I'm calling this funciton using full name call.");
        }

        static void PrintBlankLine()
        {
            Console.WriteLine(); // write a blank line
        }
    };
}
