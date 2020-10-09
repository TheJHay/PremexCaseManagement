using System;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    [Serializable]
    public class ClientDetails
    {
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        [XmlElement("LastName")]
        public string LastName { get; set; }
        [XmlElement("DOB")]
        public string DOB { get; set; }
        [XmlElement("Address")]
        public Address Address { get; set; }
        [XmlElement("Contacts")]
        public Contacts Contacts { get; set; }
    }
}