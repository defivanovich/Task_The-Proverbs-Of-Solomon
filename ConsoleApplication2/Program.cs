using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            FileInfo f = new FileInfo("G:\\Git\\ConsoleApplication2\\Files\\output\\base_output.txt");
            StreamWriter w = f.CreateText();

            using (var sr = new StreamReader("G:\\Git\\ConsoleApplication2\\Files\\input\\base.txt", Encoding.GetEncoding(1251)))
            {
                string read = null;
                while ((read = sr.ReadLine()) != null)
                { 
                    char ch = ')';
                    int indexOfChar = read.IndexOf(ch);

                    Console.WriteLine(read);
                    read = read.Substring(indexOfChar + 1);
                    read = read.Trim();
                    Console.WriteLine(read);
                string newS = "<item>" + read + "</item>";
                Console.WriteLine(newS);
                w.WriteLine(newS);
                w.Write(w.NewLine);

                }

            }
            w.Close();
            Console.ReadKey();
        }
    }
}
