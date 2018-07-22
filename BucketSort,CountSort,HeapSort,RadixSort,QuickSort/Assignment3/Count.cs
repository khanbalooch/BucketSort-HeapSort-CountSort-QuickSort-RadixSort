using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment3
{
    class Count:Main
    {
        public override void writeToFile()
        {

            string outputFile = this.GetType().ToString() + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter tw = new StreamWriter(path + @"\" + outputFile);

            tw.WriteLine("Algorithm           time Complexity           space Complexity");
            tw.WriteLine("CountSort              O(N)                          O(N)");
            tw.WriteLine("Assumption          NO ASSUMPTION");
            foreach (object s in output)
            {
                tw.WriteLine(s);
            }


            tw.Close();
        }
        public override void sort()
        {
            int k = input.Cast<Int32>().Max();
            for (int i = 0; i < input.Count + 1; i++)
            {
                output.Add(0);
            }
            int[] C = new int[k+1];

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = 0;
            }

            for (int i = 0; i < input.Count; i++)
            {
                C[(int)input[i]]++;
            }
            for (int i = 1; i < C.Length; i++)
            {
                C[i] = C[i] + C[i - 1];
            }

            for (int i = input.Count - 1; i > -1; i--)
            {
                output[C[(int)input[i]]] = (int)input[i];
                C[(int)input[i]]--;
            }
            base.sort();

        }
    }
}
