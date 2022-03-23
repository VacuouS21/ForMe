using System;

namespace MyApp
{
    class Program
    {
        static String str = "";
        public static void Main(string[] args)
        {
            var keyHandler = new KeyCheck();
            keyHandler.OnKeyPressed += ProcessChar;
            keyHandler.Run();
            Console.WriteLine("До нажатия 'c' было введено - "+str);
        }

        private static void ProcessChar(object? sender, char c)
        {
            str += c;
        }
    }
}
