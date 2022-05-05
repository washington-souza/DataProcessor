using System;
using System.IO;
using System.Text;

namespace DataProcessor.Process.Controller
{
    public class DataProcessBinary : DataProcess
    {
        public override string ReadData(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            StringBuilder sb = new StringBuilder();

            sb.Append(Convert.ToBase64String(fileBytes, 0, 4));

            return ProcessData(sb.ToString());
        }

        public override string ProcessData(string textValue)
        {
            return
                !String.IsNullOrWhiteSpace(textValue) && textValue.Length >= 7
                ? textValue.Substring(0, 7)
                : textValue;
        }
    }
}
