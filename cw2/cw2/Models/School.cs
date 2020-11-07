using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2.Models
{
    [Serializable]
    [XmlRoot(ElementName = "uczelnia")]
    public class School
    {
        [XmlAttribute(AttributeName = "createdAt")]
        public string CreatedAt { set; get; }
        [XmlAttribute(AttributeName = "author")]
        public string Author { set; get; }
        
        [XmlArray(ElementName = "studenci")]
        public List<Student> students = new List<Student>();

        private HashSet<string> studentHashes = new HashSet<string>();

        public School()
        {
            CreatedAt = DateTime.Now.ToString("dd.MM.yyyy");
        }

        public void AddStudent(Student student)
        {
            if (!studentHashes.Contains(student.ToString()))
            {
                students.Add(student);
                studentHashes.Add(student.ToString());
            }
        }
    }
}
