using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        [DllImport("UnhandledExceptionDll.Dll")]
        extern public static void DivideZero();

        [DllImport("UnhandledExceptionDll.Dll")]
        extern public static void AccessViolation();

        public static void Main(string[] args)
        {
            try
            {
                DivideZero();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                AccessViolation();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
