using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Internships
{
    [XmlRoot(ElementName = "UserAccount")]
    public class Employer
    {
        //Account Information
        [XmlAttribute(DataType = "string")]
        public string Name { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Password { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Email { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Login { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Company { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Address { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Phone { get; set; }
        [XmlAttribute(DataType = "string")]
        public string PersonalInfoFilled { get; set; }


        public Employer()
        {

        }

        public Employer(string password, string email, string login, string personalInfoFilled)
        {
            Password = password;
            Email = email;
            Login = login;
            PersonalInfoFilled = personalInfoFilled;
        }
    }
}
