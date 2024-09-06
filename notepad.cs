namespace Notepad
{
    internal class notepad
    {
        static void Main(string[] args)
        {
            const string endMessage = "write \"end\" to close the program.";
            const string clearMessage = "write \"clear\" to clear the program.";

            void PrintInstructions()
            {
                Console.WriteLine(endMessage);
                Console.WriteLine(clearMessage);
                Console.WriteLine();
            }

            PrintInstructions();

            while (true)
            {
                string response = Console.ReadLine()?.ToLower();
                if (response == "end")
                {
                    return;
                }
                if (response == "clear")
                {
                    Console.Clear();
                    PrintInstructions();
                }
            }
        }
    }
}
