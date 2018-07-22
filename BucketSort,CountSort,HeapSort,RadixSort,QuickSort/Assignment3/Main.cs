using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
{
    public class Main
    {
        public ArrayList input = new ArrayList();
        public ArrayList output = new ArrayList();
        
        public virtual void sort()
        {

            Console.WriteLine(this.GetType().ToString()+" Sort Complete");
        }
        public virtual void writeToFile()
        {
            
        }
        public void display()
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        public void loadIntegers(string file)
        {
            using (TextReader reader = File.OpenText(file))
            {
                string temp;
                while ( (temp = reader.ReadLine())!= null )
                {
                    this.input.Add(int.Parse(temp));
                }
                
                
            }
        }
        public void loadStrings(string file)
        {
            using (TextReader reader = File.OpenText(file))
            {
                string temp;
                while ((temp = reader.ReadLine()) != null)
                {
                    this.input.Add(temp);
                }
                
                Console.WriteLine("String Loaded");
            }
        }
        public void load(string file)
        {

            if (File.Exists(file))
            {


                using (TextReader reader = File.OpenText(file))
                {

                    int n;
                    bool isNumeric = int.TryParse(reader.ReadLine(), out n);
                    if (isNumeric)
                    {

                        loadIntegers(file);
                    }
                    else
                    {
                        loadStrings(file);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Path to source files\nSet path in Program.cs");
            }
        }
        

    }
}