using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int date = int.Parse(Console.ReadLine());
            if(date==30|| date == 29)
            {
                Console.WriteLine("YES");
            }else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
