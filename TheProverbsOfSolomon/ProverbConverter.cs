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

        public string ConvertString(string text)
        {
            char ch = ')';
            int indexOfChar = text.IndexOf(ch);
            text = text.Substring(indexOfChar + 1).Trim();
            text = String.Format("<item>{0}</item>", text);

            return text;
        }

        public void Convert()
        {
            string read = null;
            
            StringBuilder builder = new StringBuilder();

            using (var sr = new StreamReader(inputFileName, Encoding.GetEncoding(1251)))
            {

                while ((read = sr.ReadLine()) != null)
                {
                    builder.Append(ConvertString(read)).AppendLine();
                }
            }

            File.WriteAllText(outputFileName, builder.ToString());
        }

    }
}
