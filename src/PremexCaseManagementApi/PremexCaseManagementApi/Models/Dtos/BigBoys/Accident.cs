using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    [Serializable]
    public class Accident
    {
        [XmlElement("AccidentDate")]
        public string AccidentDate { get; set; }
        [XmlElement("AccidentTime")]
        public string AccidentTime { get; set; }
        [XmlArray("InjuryList")]
        public List<Injury> InjuryList { get; set; }
    }

    public class Injury 
    {
        [XmlText]
        public string Value { get; set; }
    }
}