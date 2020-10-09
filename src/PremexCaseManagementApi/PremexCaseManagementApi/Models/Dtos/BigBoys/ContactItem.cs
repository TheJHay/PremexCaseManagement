using System;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    //[Serializable]
    public class ContactItem
    {
        [XmlAttribute]
        public string Preferred { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}


