using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    /// <summary>
    /// POCO for XML 'Header' object defined in BigBoys request schema
    /// </summary>
    [Serializable]
    public class Header
    {
        [XmlElement]
        public string Date { get; set; }
        [XmlElement]
        public string Time { get; set; }
        [XmlElement]
        public string Type { get; set; }
        [XmlElement]
        public string MedicalAgent { get; set; }
        [XmlElement]
        public string Branch { get; set; }
        [XmlElement]
        public string PurchaseOrder { get; set; }
        [XmlElement]
        public string MessageId { get; set; }
    }
}
