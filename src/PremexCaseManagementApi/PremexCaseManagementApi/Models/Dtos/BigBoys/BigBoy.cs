using System;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    [Serializable]
    public class BigBoy
    {
        [XmlElement("EntityRef")]
        public string EntityRef { get; set; }
        [XmlElement("MatterNo")]
        public int MatterNo { get; set; }
        [XmlElement("CompanyBranch")]
        public string CompanyBranch { get; set; }
        [XmlElement("Introducer")]
        public string Introducer { get; set; }
    }
}