using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_8_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o;
            int i = 100;
            Type t1 = i.GetType();
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.FullName);
            Console.ReadLine();
        } 
    }
}
