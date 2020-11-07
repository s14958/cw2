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
        [XmlAttribute]
        public string createdAt { set; get; }
        [XmlAttribute]
        public string author { set; get; }
        
        [XmlArray(ElementName = "studenci")]
        public List<Student> students { set; get; } = new List<Student>();

        public School()
        {
            createdAt = DateTime.Now.ToString("dd.MM.yyyy");
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
