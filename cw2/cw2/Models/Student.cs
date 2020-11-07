using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2.Models
{
    [Serializable]
    [XmlRoot(ElementName = "student")]
    public class Student
    {
        [XmlAttribute(AttributeName = "indexNumber")]
        public string IndexNumber { get; set; }

        [XmlElement(ElementName = "fname")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "lname")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "birthdate")]
        public string BirthDate { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "mothersName")]
        public string MothersName { get; set; }

        [XmlElement(ElementName = "fathersName")]
        public string FathersName { get; set; }

        [XmlElement(ElementName = "studies")]
        public Study Studies = new Study();

        override public string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
