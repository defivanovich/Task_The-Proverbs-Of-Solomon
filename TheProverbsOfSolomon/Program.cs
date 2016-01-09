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
            var inputFileName = "G:\\Git\\Projects\\Files\\input\\base.txt";
            var outputFileName = "G:\\Git\\Projects\\Files\\output\\base_output.txt";
            var ProverbConverter = new ProverbConverter(inputFileName, outputFileName);
            ProverbConverter.Convert();
            Console.WriteLine("Готово!");
            Console.ReadKey();
        }
    }
}
