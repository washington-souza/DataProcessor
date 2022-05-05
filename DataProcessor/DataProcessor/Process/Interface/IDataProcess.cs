using DataProcessor.Process.Enum;

namespace DataProcessor.Process.Interface
{
    public interface IDataProcess
    {
        string ReadData(string filePath);
        abstract string ProcessData(string Data);
    }
}