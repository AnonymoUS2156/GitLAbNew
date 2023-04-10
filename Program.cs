using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 4;
            Console.WriteLine($"5*Math.Cos(2*{s})={5*Math.Cos(2*s)}");
            Console.ReadKey();
        }
    }
}
