using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Internships
{
    [XmlRoot(ElementName = "UserAccount")]
    public class Student
    {
        //Personal Information
        [XmlAttribute(DataType = "string")]
        public string FirstName { get; set; }
        [XmlAttribute(DataType = "string")]
        public string LastName { get; set; }
        [XmlAttribute(DataType = "string")]
        public string BirthDate { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Gender { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Race { get; set; }
        [XmlAttribute(DataType = "string")]
        public string StreetNumber { get; set; }
        [XmlAttribute(DataType = "string")]
        public string StreetName { get; set; }
        [XmlAttribute(DataType = "string")]
        public string City { get; set; }
        [XmlAttribute(DataType = "string")]
        public string State { get; set; }
        [XmlAttribute(DataType = "string")]
        public string ZipCode { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Country { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Nationality { get; set; }
        [XmlAttribute(DataType = "string")]
        public string PhoneNumber { get; set; }

        //Educational Information
        [XmlAttribute(DataType = "string")]
        public string School { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Major { get; set; }
        [XmlAttribute(DataType = "string")]
        public string GPA { get; set; }
        [XmlAttribute(DataType = "string")]
        public string EnrollmentYear { get; set; }
        [XmlAttribute(DataType = "string")]
        public string ExpectedGraduationYear { get; set; }
        [XmlAttribute(DataType = "string")]
        public string CollegeStanding { get; set; }
        
        public Student()
        { }
    }
}
