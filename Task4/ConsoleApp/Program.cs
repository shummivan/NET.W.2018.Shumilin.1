using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryUniversity;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            University uni = new University("BNTU","test1");

            Console.WriteLine(uni.ToString());
            Console.ReadKey();
        }
    }
}
