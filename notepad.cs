using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace workbook1
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