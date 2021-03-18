using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YeldTest
{
    [XmlRoot("Address")]
    public class AddressDetails
    {
        [XmlAttribute("AddressID")]
        public string AddressId { get; set; }
        [XmlElement("Number")]
        public int HouseNo { get; set; }
        [XmlElement("Street")]
        public string StreetName { get; set; }
        [XmlElement("CityName")]
        public string City { get; set; }
        private string PoAddress { get; set; }

        public override string ToString()
        {
            return String.Format("R: {0}, {1} - {2}", StreetName, HouseNo, City);
        }
    }

    public class Designation
    {
        [XmlAttribute("place")]
        public string place { get; set; }
        [XmlText]
        public string JobType { get; set; }
    }

    public class AddressDirectory
    {
        [XmlElement("DirectoryOwner")]
        public string DirectoryOwner { get; set; }
        [XmlElement("PinCode")]
        public string PinCode { get; set; }
        [XmlElement("Address")]
        //public List<AddressDetails> address { get; set; }
        public List<AddressDetails> address = new List<AddressDetails>();
        [XmlElement("Designation")]
        public Designation designation { get; set; }
    }
}
