using System;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath, resultPath, format;

            try
            {
                csvPath = args[0];
            } catch
            {
                csvPath = "data.csv";
            }

            try
            {
                resultPath = args[1];
            } catch
            {
                resultPath = "result.xml";
            }

            try
            {
                format = args[2];
            } catch
            {
                format = "xml";
            }

            
            Console.WriteLine("csvPath: " + csvPath);
            Console.WriteLine("resultPath: " + resultPath);
            Console.WriteLine("format: " + format);
        }
    }
}
