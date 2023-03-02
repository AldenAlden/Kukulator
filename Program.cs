using System;
using System.Linq.Expressions;

namespace Kukulator2
{

    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Select an operation to perform");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");
            Console.WriteLine("5. BRACKETS");

            var operation = Convert.ToString(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            void getInputs()
            {
                Console.WriteLine("Enter first number:");
                string? input1 = Console.ReadLine();
                if (!string.IsNullOrEmpty(input1)) //handles null exception
                {
                    operation = ""; 
                } 
                else
                {
                    num1 = Convert.ToInt32(input1);
                }

                Console.WriteLine("Enter second number:");
                string? input2 = Console.ReadLine();
                if (!string.IsNullOrEmpty(input2)) //handles null exception
                { 
                    operation = "";
                }
                else
                {
                    num2 = Convert.ToInt32(input2);
                }
                
            }

            switch (operation)
            {
                case "1": //Add
                    getInputs();
                    Console.WriteLine("The Sum is:");
                    Console.WriteLine("{0}", num1 + num2 );
                    break;
                case "2": //Subtract
                    getInputs();
                    Console.WriteLine("The Difference is:");
                    Console.WriteLine("{0}", num1 - num2 );
                    break;
                case "3": //Multiply
                    getInputs();
                    Console.WriteLine("The Product is:");
                    Console.WriteLine("{0}", num1 * num2 );
                    break;
                case "4": //Divide
                    getInputs();
                    Console.WriteLine("The Result is:");
                    Console.WriteLine("{0}", num1 / num2 );
                    break;
                case "5": //Brackets
                    Console.WriteLine("Enter expression:");
                    var expression = Console.ReadLine();
                    Console.WriteLine("The Result is:");
                    Console.WriteLine("{0}", Convert.ToInt32(expression));
                    break;
                default: //Default
                    Console.WriteLine("Invalid entry");
                    break;
            }
            Console.WriteLine("Press and key...");
            Console.ReadKey(); // await for keypress
            Main();
        }
    }
}