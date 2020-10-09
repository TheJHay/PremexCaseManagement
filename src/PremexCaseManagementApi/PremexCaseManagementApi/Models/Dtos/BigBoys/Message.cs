using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PremexCaseManagementApi.Models.Dtos.BigBoys
{
    [Serializable]
    [XmlRoot]
    public class Message
    {
        [XmlElement]
        public Header Header { get; set; }
        [XmlElement]
        public MessageBody MessageBody { get; set; }
    }
}
