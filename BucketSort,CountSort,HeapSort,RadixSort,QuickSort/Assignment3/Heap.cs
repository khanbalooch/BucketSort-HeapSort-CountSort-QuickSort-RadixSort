using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment3
{
    class Heap:Main
    {
        int size;

        public override void writeToFile()
        {

            string outputFile = this.GetType().ToString() + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter tw = new StreamWriter(path + @"\" + outputFile);

            tw.WriteLine("Algorithm           time Complexity           space Complexity");
            tw.WriteLine("HeapSort              O(nLog(n))                    O(N)");
            tw.WriteLine("Assumption          NO ASSUMPTION");
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

            BUILD_MAX_HEAP(output);
            for (int i = output.Count-1; i > -1; i--)
            {
                exchange(0,i,ref output);
                size--;
                MAX_HEAPIFY(ref output, 0, i - 1);

            }
            base.sort();

        }
        public void BUILD_MAX_HEAP(ArrayList heap)
        {
            size = heap.Count-1;
            for (int i = size / 2; i>-1; i--)
            {
                MAX_HEAPIFY(ref heap,i,size);
            }
            

        }
        public void MAX_HEAPIFY(ref ArrayList heap,int i,int n)
        {
            int largest = i;
            int l = i * 2 + 1;//LEFT(i)
            int r = i * 2 + 2;//RIGHT(i)

            if (l <= n && ((int)heap[l] > (int)heap[i]))
            {
                largest = l;
            }
            else
            {
                largest = i;
            }
            if (r <= n && (int)heap[r] > (int)heap[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                exchange(i,largest,ref heap);
                MAX_HEAPIFY(ref heap, largest, n);
            }
                
                

        }
        public void exchange(int x , int y, ref ArrayList list)
        {
            Object temp = list[x];
            list[x] = list[y];
            list[y] = temp;
        }
    }
}
