using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
{
    class Bucket:Main
    {
        public override void writeToFile()
        {

            string outputFile = this.GetType().ToString() + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter tw = new StreamWriter(path + @"\" + outputFile);

            tw.WriteLine("Algorithm           time Complexity           space Complexity");
            tw.WriteLine("BucketSort              O(N)                          O(N)");
            tw.WriteLine("Assumption          Insertion sort timeCompleity is O(N)best case");
            foreach (object s in output)
            {
                tw.WriteLine(s);
            }


            tw.Close();
        }
        public override void sort()
      {
            int max = input.Cast<Int32>().Max();
            int min = input.Cast<Int32>().Min();

            List<Double>[] B = new List<Double>[input.Count];
             //distribute [0,1) into n equal intervals
            for (int i = 0; i <B.Length; i++)
            {
                B[i] = new List<Double>();
            }
            // distribute the input over the interval
            for (int i = 0; i < input.Count; i++)
            {
                int index = ((int)input[i] * input.Count) / (max + 1);
                B[index-1].Add((int)input[i]);
            }
            // do the insertion sort for every bucket
            for (int i = 0; i < B.Length; i++)
            {
                insertionSort(ref B[i]);
            }
            
            for (int i = 0; i < B.Length; i++)
            {
                    output.AddRange(B[i]); 
            }
            base.sort();

        }

        public void insertionSort(ref List<double> input)
        {
            if (input.Count > 0)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (input[j - 1] > input[j])
                        {
                            double temp = input[j - 1];
                            input[j - 1] = input[j];
                            input[j] = temp;
                        }
                    }
                }

            }
            

            
        }
    }
}