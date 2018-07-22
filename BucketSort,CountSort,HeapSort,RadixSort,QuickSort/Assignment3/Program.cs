using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string IntegerInput = @"C:\Users\Balooch\Downloads\SMS-6\ALGO\Assignments\IntegerInput.txt";
            //string StringInput = @"C:\Users\Balooch\Downloads\SMS-6\ALGO\Assignments\StringInput.txt";
            

            Main[] technique=new Main[5];

            technique[0] = new Bucket();
            technique[1] = new Count();
            technique[2] = new Heap();
            technique[3] = new Quick();
            technique[4] = new Radix();


            foreach (Main algorithm in technique)
            {
                algorithm.load(IntegerInput);
                algorithm.sort();
                algorithm.writeToFile();
            }
            Console.WriteLine("Output Files Generated to Desktop");            
            
            Console.ReadLine();
        }
    }
}