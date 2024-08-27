using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models.DTO
{
    public class CaseDto
    {
        public int CaseId { get; set; }
        public string caseNumber { get; set; }
        public int practitionerId { get; set; }
        public string practitioner { get; set; }
        public int caseTypeId { get; set; }
        public string caseType { get; set; }
        public DateTime fileOpeningDate { get; set; }
        public string eligibilityPeriod { get; set; }
        public DateTime CloseDiscussion { get; set; }
        public int respondentProxyId { get; set; }
        public string respondentProxy { get; set; }
        public int chairmanCommitteeId { get; set; }
        public string chairmanCommittee { get; set; }
        public int publicRepresentativeId { get; set; }
        public string publicRepresentative { get; set; }
        public int statusId { get; set; }
        public string status { get; set; }

    }
}
