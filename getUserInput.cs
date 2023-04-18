namespace Kukulator2
{
    internal class getUserInput
    {
        public static int getInput()
        {
            Console.WriteLine("Enter number:");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !userInput.All(char.IsDigit)) //check for null exceptions OR userInput is not numeric
            {
                Console.WriteLine("Invalid Entry \n Press any key to continue");
                Console.ReadKey(); // await for keypress
                Program.Main();
                return 0;
            }
            else
            {
                return Convert.ToInt32(userInput);
            }
        }
    }
}
