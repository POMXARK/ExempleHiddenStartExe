using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ExempleHiddenStartExe
{

    class Program
    {

        // Use DllImport to import the Win32 MessageBox function.
        //[DllImport("user32.dll")]

        //public static extern void MessageBox(IntPtr hWnd, String text, String caption, uint type);
        
        
        

        [DllImport("HiddenStartExe.dll",  CallingConvention = CallingConvention.Cdecl)]
        //[return: MarshalAs(UnmanagedType.BStr)]
        //public static extern void GetString([MarshalAs(UnmanagedType.LPStr)] string lpString);

        private static extern void HiddenStart(string prog);

        //public static extern int HiddenStart([MarshalAs(UnmanagedType.LPStr)] string filename);

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            // Convert from System::String to Char in Visual C++

            string progName = "main.exe";
            //GetString(progName);
            //HiddenStart("main.exe");
            HiddenStart(progName);

            // Call the MessageBox function using platform invoke.
            //MessageBox(new IntPtr(0), "Hello World!", "Hello Dialog", 0);

            }
    }
}
