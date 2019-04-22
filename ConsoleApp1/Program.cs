using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("UnhandledExceptionDll.Dll")]
        extern public static void DivideZero();

        [DllImport("UnhandledExceptionDll.Dll")]
        extern public static void AccessViolation();

        [DllImport("UnhandledExceptionDll.Dll")]
        extern public static void UnhandledThrow();

        [HandleProcessCorruptedStateExceptions]
        public static void Main(string[] args)
        {

            try
            {
                AccessViolation();
            }
            catch (AccessViolationException ave)
            {
                Console.WriteLine(ave.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                UnhandledThrow();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                DivideZero();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
    }
}


