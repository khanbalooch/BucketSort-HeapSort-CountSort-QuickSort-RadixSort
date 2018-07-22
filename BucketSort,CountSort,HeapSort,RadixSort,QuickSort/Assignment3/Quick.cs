using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment3
{
    class Quick:Main
    {
        public override void writeToFile()
        {

            string outputFile = this.GetType().ToString() + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter tw = new StreamWriter(path + @"\" + outputFile);

            tw.WriteLine("Algorithm           time Complexity           space Complexity");
            tw.WriteLine("QuickSort              O(Nlog(n))                    O(N)");
            tw.WriteLine("Assumption          NO ASSUPTION");
            foreach (object s in output)
            {
                tw.WriteLine(s);
            }


            tw.Close();
        }
        public override void sort()
        {
            for (int i = 0; i < input.Count; i++)
            {
                output.Add((int)input[i]);
            }
            QuickSort(ref output, 0, output.Count-1);
            base.sort();
        }
        
        public void QuickSort(ref ArrayList A,int p, int r)
        {
            if (p < r)
            {
                int q = Partition(ref A, p, r);
                QuickSort(ref A, p, q - 1);
                QuickSort(ref A, q + 1, r);
            }
        }
        public void exchange(int x, int y, ref ArrayList list)
        {
            Object temp = list[x];
            list[x] = list[y];
            list[y] = temp;
        }
        public  int Partition(ref ArrayList a, int p, int r)
        {
            int x =(int)a[r];		// x is pivot
            int i = p - 1;

            for(int j= p; j<r; j++)
            {
                if ((int)a[j] <= x)
                {
                    i = i + 1;
                    exchange(i,j,ref a);
                }
            }
            exchange(i + 1,r,ref a);
            return i + 1;
        }

    }
}