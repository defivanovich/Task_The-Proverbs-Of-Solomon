using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheProverbsOfSolomon
{

    public class Converter
    {
        public string inputFileName, outputFileName;
        public Converter(string inputFileName, string outputFileName)
        {
            this.inputFileName = inputFileName;
            this.outputFileName = outputFileName;
        }

        public void Convert()
        {
            string read = null;
            char ch = ')';

            FileInfo f = new FileInfo(outputFileName);
            StreamWriter w = f.CreateText();

            using (var sr = new StreamReader(inputFileName, Encoding.GetEncoding(1251)))
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

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var inputFileName = "G:\\Git\\Projects\\Files\\input\\base.txt";
            var outputFileName = "G:\\Git\\Projects\\Files\\output\\base_output.txt";
            var converter = new Converter(inputFileName, outputFileName);
            converter.Convert();
            Console.WriteLine("Готово!");
            Console.ReadKey();
        }
    }
}
