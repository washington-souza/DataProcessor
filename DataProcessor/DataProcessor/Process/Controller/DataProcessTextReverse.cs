using System;
using System.Linq;

namespace DataProcessor.Process.Controller
{
    public class DataProcessTextReverse : DataProcess
    {
        public override string ProcessData(string data)
        {
            var textValue = new string(data.Reverse().ToArray());
            return
                !String.IsNullOrWhiteSpace(textValue) && textValue.Length >= 6
                ? textValue.Substring(0, 6)
                : textValue;
        }
    }
}
