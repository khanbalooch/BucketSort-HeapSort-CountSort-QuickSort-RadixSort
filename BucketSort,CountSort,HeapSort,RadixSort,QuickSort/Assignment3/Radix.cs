using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment3
{
    class Radix:Main
    {
        public override void writeToFile()
        {

            string outputFile = this.GetType().ToString() + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter tw = new StreamWriter(path + @"\" + outputFile);

            tw.WriteLine("Algorithm           time Complexity           space Complexity");
            tw.WriteLine("RadixSort              K*O(N)                          O(N)");
            tw.WriteLine("Assumption          Insertion sort timeCompleity is O(N)best case");
            foreach (object s in output)
            {
                tw.WriteLine(s);
            }


            tw.Close();
        }
        public override void sort()
        {
            int totalPass = input.Cast<Int32>().Max().ToString().Length;

            for (int i = 0; i < 10; i++)
            {
                output.Add(new ArrayList());
            }
           
            int divisor = 1;

            
            for (int i = totalPass; i >-1; i--)
            {
                
                for (int j = 0; j < input.Count; j++)
                {
                    int index = ((int)input[j] / divisor) % 10;
                    ArrayList items = (ArrayList)output[index];
                    items.Add(input[j]);
                    output[index] = items;
                }
                input.Clear();
                divisor = divisor * 10;
                
                for (int j = 0; j < 10; j++)
                {
                    input.AddRange((ArrayList)output[j]);
                    ArrayList tem = (ArrayList)output[j]; //= null;
                    tem.Clear();
                    output[j] = tem;
                 }
                
            }
            output.Clear();
            output = input;
            base.sort();

        }

    }
}
