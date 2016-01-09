using System;
using System.Text;
using System.IO;

namespace TheProverbsOfSolomon
{
    public class ProverbConverter 
    {
        private string inputFileName;
        private string outputFileName;

        public ProverbConverter(string inputFileName, string outputFileName)
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
}
