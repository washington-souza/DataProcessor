using System;

namespace DataProcessor.Process.Controller
{
    public class DataProcessText : DataProcess
    { 
        public override string ProcessData(string data)
        {
            return
                !String.IsNullOrWhiteSpace(data) && data.Length >= 7
                ? data.Substring(0, 7)
                : data;
        }
    }
}
