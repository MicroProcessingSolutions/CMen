using System;
namespace CMen.Utils
{
    public static class CMenConsole
    {
        public static bool GenerateOutput { get; set; }
        public const string Signature = "[CMen] ";
        public static void WriteLine(Object data)
        {
            if(GenerateOutput)
                Console.WriteLine(Signature + data.ToString());
        }
        public static void WriteLine(string text)
        {
            if(GenerateOutput)
                Console.WriteLine(Signature + text.ToString());
        }

        static CMenConsole()
        {
            GenerateOutput = true;
        }
    }
}