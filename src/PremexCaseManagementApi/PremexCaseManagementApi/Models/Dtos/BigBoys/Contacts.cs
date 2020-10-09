using System;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    //[Serializable]
    public class Contacts
    {
        [XmlElement("TelHome")]
        public ContactItem TelHome { get; set; }
        [XmlElement("TelWork")]
        public ContactItem TelWork { get; set; }
        [XmlElement("TelMobile")]
        public ContactItem TelMobile { get; set; }
        [XmlElement("EmailHome")]
        public ContactItem EmailHome { get; set; }
        [XmlElement("EmailWork")]
        public ContactItem EmailWork { get; set; }
    }
}