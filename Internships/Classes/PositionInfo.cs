using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Internships
{
    [XmlRoot(ElementName = "PositionInfo")]
    public class PositionInfo
    {
        [XmlAttribute(DataType = "string")]
        public string CompanyName { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Position { get; set; }
        [XmlAttribute(DataType = "string")]
        public string TimePeriod { get; set; }
        [XmlAttribute(DataType = "string")]
        public string City { get; set; }
        [XmlAttribute(DataType = "string")]
        public string State { get; set; }
        [XmlAttribute(DataType = "string")]
        public string Sponsorship { get; set; }
        [XmlAttribute(DataType = "string")]
        public string ApplicationLink { get; set; }
        [XmlAttribute(DataType = "string")]
        public string CoverLetterRequired { get; set; }

        public PositionInfo(){}

        public PositionInfo(string companyName, string position, string timePeriod, string city, string state, string sponsorship, string applicationLink, string coverLetterRequired)
        {
            CompanyName = companyName;
            Position = position;
            TimePeriod = timePeriod;
            City = city;
            State = state;
            Sponsorship = sponsorship;
            ApplicationLink = applicationLink;
            CoverLetterRequired = coverLetterRequired;
        }

        internal static PositionInfo ParseFromFile(string line)
        {
            //separates the string into a different indice every time a ',' is reached
            var columns = line.Split(',');
            //instantiation of the Car object
            return new PositionInfo
            {
                CompanyName = columns[0],
                Position = columns[1],
                TimePeriod = columns[2],
                City = columns[3],
                State = columns[4],
                Sponsorship = columns[5],
                ApplicationLink = columns[6],
                CoverLetterRequired = columns[7]
            };
        }

        public override string ToString()
        {
            return $"{CompanyName}, {Position}, {TimePeriod}, {City}, {State}, " +
                $"{Sponsorship}, {CoverLetterRequired}";
        }
    }
}
