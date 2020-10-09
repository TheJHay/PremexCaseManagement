using System;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    [Serializable]
    public class Instruction
    {
        [XmlElement]
        public BigBoy BigBoy { get; set; }
        [XmlElement]
        public Accident Accident { get; set; }
        [XmlElement]
        public ClientDetails ClientDetails { get; set; }
    }
}