using static Kukulator2.getUserInput;
namespace Kukulator2
{
    internal class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Select an operation to perform");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");
            Console.WriteLine("5. EXIT");

            var operation = Convert.ToString(Console.ReadLine());

            int num1;
            int num2;
            switch (operation)
            {
                case "1": //Add
                    num1 = getInput();
                    num2 = getInput();
                    Console.WriteLine("The Sum is:");
                    Console.WriteLine("{0}", num1 + num2);
                    break;
                case "2": //Subtract
                    num1 = getInput();
                    num2 = getInput();
                    Console.WriteLine("The Difference is:");
                    Console.WriteLine("{0}", num1 - num2);
                    break;
                case "3": //Multiply
                    num1 = getInput();
                    num2 = getInput();
                    Console.WriteLine("The Product is:");
                    Console.WriteLine("{0}", num1 * num2);
                    break;
                case "4": //Divide
                    num1 = getInput();
                    num2 = getInput();
                    Console.WriteLine("The Result is:");
                    Console.WriteLine("{0}", num1 / num2);
                    break;
                case "5":
                case "exit": //Exit
                    Environment.Exit(0);
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