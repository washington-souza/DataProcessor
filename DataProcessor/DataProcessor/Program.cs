using DataProcessor.Process.Controller;
using DataProcessor.Process.Enum;
using System;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No args was provided");
            }
            else
            {
                string filePath = args[0];
                string dataTypeInput = args[1];

                var dataType = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), dataTypeInput, true);

                string dataContent = "";
                switch (dataType)
                {
                    case DataTypeEnum.Binary:
                        dataContent = new DataProcessBinary().ReadData(filePath);
                        break;
                    case DataTypeEnum.Text:
                        dataContent = new DataProcessText().ReadData(filePath);
                        break;
                    case DataTypeEnum.TextReverse:
                        dataContent = new DataProcessTextReverse().ReadData(filePath);
                        break;
                }

                Console.WriteLine(dataContent);
            }
        }
    }
}
