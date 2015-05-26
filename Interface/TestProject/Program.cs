using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Process currentProcess = Process.GetCurrentProcess();
            Console.WriteLine(currentProcess.Id);
            Console.ReadKey();
        }
    }
}
