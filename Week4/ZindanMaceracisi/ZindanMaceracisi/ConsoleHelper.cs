namespace ZindanMaceracisi
{
    public static class ConsoleHelper
    {
        public static void WriteLineColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void WriteColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.Write(text);
            Console.ResetColor();
        }

    }

}