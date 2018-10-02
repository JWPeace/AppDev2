using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_notes
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i<args.Length; i++)
            //{
            //    Console.WriteLine("Args: {0}", args[i]);
            //}
            DataTypes.Display();
            if(args.Contains("red"))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
