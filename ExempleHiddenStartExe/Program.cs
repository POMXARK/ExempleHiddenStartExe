using System;
using System.Runtime.InteropServices;


namespace ExempleHiddenStartExe
{

    class Program
    {
 
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            string progName = "main.exe";

            HiddenStart(progName);

            }

        [DllImport("HiddenStartExe.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void HiddenStart(string prog);


    }
}
