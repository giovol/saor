/*
 * CustomConsole in saor.Core
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/giovol/saor/blob/main/LICENSE
 * Project link: https://github.com/giovol/saor
 */

using System;

namespace saor.Core
{
    public static class CustomConsole
    {
        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
            Console.Write(message);
            Console.WriteLine();
        }
        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("SUCCESS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
            Console.Write(message);
            Console.WriteLine();
        }
        public static void WriteDebug(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("DEBUG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
            Console.Write(message);
            Console.WriteLine();
        }
        public static void WriteInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("INFO");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
            Console.Write(message);
            Console.WriteLine();
        }
        public static void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARNING");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
            Console.Write(message);
            Console.WriteLine();
        }
    }
}
