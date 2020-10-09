using System;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    [Serializable]
    public class Address
    {
        [XmlElement("Address1")]
        public string Address1 { get; set; }
        [XmlElement("Address2")]
        public string Address2 { get; set; }
        [XmlElement("Address3")]
        public string Address3 { get; set; }
        [XmlElement("Address4")]
        public string Address4 { get; set; }
        [XmlElement("Postcode")]
        public string Postcode { get; set; }
    }
}