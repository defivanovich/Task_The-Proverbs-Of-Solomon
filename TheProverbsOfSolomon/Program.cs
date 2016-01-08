using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheProverbsOfSolomon
{
    class Program
    {
        static void Main(string[] args)
        {
            string read = null;
            char ch = ')';

            FileInfo f = new FileInfo("G:\\Git\\Projects\\Files\\base_output.txt");
            StreamWriter w = f.CreateText();

            using (var sr = new StreamReader("G:\\Git\\Projects\\Files\\input\\base.txt", Encoding.GetEncoding(1251)))
            {
                
                while ((read = sr.ReadLine()) != null)
                {
                   
                    int indexOfChar = read.IndexOf(ch);

                    read = read.Substring(indexOfChar + 1).Trim();
           
                    var newS = String.Format("<item>{0}</item>", read);       
                    w.WriteLine(newS);
                    w.Write(w.NewLine);

                }

            }
            w.Close();
            Console.WriteLine("Готово!");
            Console.ReadKey();
        }
    }
}
