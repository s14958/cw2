using cw2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath, resultPath, format;
            string errorPath = "log.txt";

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

            var school = new School
            {
                Author = "Hubert Siwkin"
            };
            LoadStudentsData(csvPath, school);
        }

        private static void LoadStudentsData(string filePath, School school)
        {
            using (var stream = new StreamReader(File.OpenRead(filePath)))
            {
                string line = null;

                while ((line = stream.ReadLine()) != null)
                {
                    string[] student = line.Split(',');
                    var st = new Student
                    {
                        FirstName = student[0],
                        LastName = student[1],
                        Studies = new Study
                        {
                            Name = student[2],
                            Mode = student[3]
                        },
                        IndexNumber = 's' + student[4],
                        BirthDate = student[5],
                        Email = student[6],
                        MothersName = student[7],
                        FathersName = student[8]
                    };

                    school.AddStudent(st);
                }
            }
            SerializeSchool(@"C:\Users\hsiwk\Desktop\wynik.xml", school);
        }

        private static void SerializeSchool(string resultPath, School school)
        {
            FileStream writer = new FileStream(resultPath, FileMode.Create);            
            XmlSerializer serializer = new XmlSerializer(typeof(School));

            serializer.Serialize(writer, school);
        }
    }
}
