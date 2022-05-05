using DataProcessor.Process.Interface;

namespace DataProcessor.Process.Controller
{
    public abstract class DataProcess : IDataProcess
    {
        public virtual string ReadData(string filePath)
        {
            var data = System.IO.File.ReadAllText(filePath);
            return ProcessData(data);
        }

        public abstract string ProcessData(string data);
    }
}