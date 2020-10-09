using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremexCaseManagementApi.Models.Entities
{
    public class PremexCase
    {
        public int CaseId { get; set; }
        public string AccidentDate { get; set; }
        public string AccidentTime { get; set; }
        public string Injuries { get; set; }
        public string ClientAddress1 { get; set; }
        public string ClientAddress2 { get; set; }
        public string ClientAddress3 { get; set; }
        public string ClientAddress4 { get; set; }
        public string ClientDOB { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientPostcode { get; set; }
        public string ClientTelHome { get; set; }
        public string ClientTelMob { get; set; }
        public string ClientTelWork { get; set; }
        public string ClientTitle { get; set; }
        public int WorksourceId { get; set; }
    }
}
