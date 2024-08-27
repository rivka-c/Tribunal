using Case.BL.Services.Interfaces;
using CaseService.DAL.Repositories;
using Messaging.Interfaces;
using Shared.Messaging;
using Shred.Models.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaseService.BL.Services
{
    public class CaseServic : ICaseService
    {
        private readonly ICaseRepository _caseRepository;
        private readonly IMessagePublisher _messagePublisher;

        public CaseServic(ICaseRepository caseRepository, IMessagePublisher messagePublisher)
        {
            _caseRepository = caseRepository;
            _messagePublisher = messagePublisher;
        }

        public async Task<CaseDto> CreateCaseAsync(CaseDto caseDto)
        {
            var newCase = _caseRepository.CreateCase(caseDto);

            var notificationMessage = new NotificationMessage
            {
                CaseId = newCase.CaseId,
                Message = "New case created"
            };

            await _messagePublisher.PublishAsync(notificationMessage);

            return newCase;
        }
        public async Task<List<CaseDto>> GetCases()
        {


            List<CaseDto> cases = new List<CaseDto>
            {
            new CaseDto
            {
                CaseId = 1,
                CaseNumber = "12345",
                CaseType = "תביעה אזרחית",
                CaseTypeId = 1,
                FileOpeningDate = new DateTime(2023, 1, 1),
                EligibilityPeriod = "2023-01-01 עד 2023-12-31",
                CloseDiscussion = new DateTime(2023, 12, 31),
                RespondentProxyId = 201,
                RespondentProxy = "עו\"ד רונית לוי",
                ChairmanCommitteeId = 301,
                ChairmanCommittee = "מר חיים ישראלי",
                PublicRepresentativeId = 401,
                PublicRepresentative = "גב' מרים כהן",
                AppealSubmitterId = 501,
                AppealSubmitter = "מר יוסי לוי",
                PractitionerId = 101,
                Practitioner = "עו\"ד יוסי כהן",
                StatusId = 1,
                Status = "פתוח"
            },
            new CaseDto
            {
                CaseId = 2,
                CaseNumber = "67890",
                CaseType = "תביעה פלילית",
                CaseTypeId = 2,
                FileOpeningDate = new DateTime(2023, 2, 1),
                EligibilityPeriod = "2023-02-01 עד 2023-11-30",
                CloseDiscussion = new DateTime(2023, 11, 30),
                RespondentProxyId = 202,
                RespondentProxy = "עו\"ד דני כהן",
                ChairmanCommitteeId = 302,
                ChairmanCommittee = "מר יעקב לוי",
                PublicRepresentativeId = 402,
                PublicRepresentative = "גב' רחל ישראלי",
                AppealSubmitterId = 502,
                AppealSubmitter = "מר אבי כהן",
                PractitionerId = 102,
                Practitioner = "עו\"ד דני לוי",
                StatusId = 2,
                Status = "סגור"
            },
            new CaseDto
            {
                CaseId = 3,
                CaseNumber = "11223",
                CaseType = "תביעה מנהלית",
                CaseTypeId = 3,
                FileOpeningDate = new DateTime(2023, 3, 1),
                EligibilityPeriod = "2023-03-01 עד 2023-10-31",
                CloseDiscussion = new DateTime(2023, 10, 31),
                RespondentProxyId = 203,
                RespondentProxy = "עו\"ד יעל ישראלי",
                ChairmanCommitteeId = 303,
                ChairmanCommittee = "מר דני לוי",
                PublicRepresentativeId = 403,
                PublicRepresentative = "גב' שרה כהן",
                AppealSubmitterId = 503,
                AppealSubmitter = "מר משה לוי",
                PractitionerId = 103,
                Practitioner = "עו\"ד יעל לוי",
                StatusId = 1,
                Status = "פתוח"
            },
            new CaseDto
            {
                CaseId = 4,
                CaseNumber = "44556",
                CaseType = "תביעה כספית",
                CaseTypeId = 4,
                FileOpeningDate = new DateTime(2023, 4, 1),
                EligibilityPeriod = "2023-04-01 עד 2023-09-30",
                CloseDiscussion = new DateTime(2023, 9, 30),
                RespondentProxyId = 204,
                RespondentProxy = "עו\"ד מיכל לוי",
                ChairmanCommitteeId = 304,
                ChairmanCommittee = "מר יוסי כהן",
                PublicRepresentativeId = 404,
                PublicRepresentative = "גב' מיכל ישראלי",
                AppealSubmitterId = 504,
                AppealSubmitter = "מר דוד כהן",
                PractitionerId = 104,
                Practitioner = "עו\"ד מיכל כהן",
                StatusId = 2,
                Status = "סגור"
            },
            new CaseDto
            {
                CaseId = 5,
                CaseNumber = "77889",
                CaseType = "תביעה נזיקית",
                CaseTypeId = 5,
                FileOpeningDate = new DateTime(2023, 5, 1),
                EligibilityPeriod = "2023-05-01 עד 2023-08-31",
                CloseDiscussion = new DateTime(2023, 8, 31),
                RespondentProxyId = 205,
                RespondentProxy = "עו\"ד רון לוי",
                ChairmanCommitteeId = 305,
                ChairmanCommittee = "מר אבי ישראלי",
                PublicRepresentativeId = 405,
                PublicRepresentative = "גב' יעל כהן",
                AppealSubmitterId = 505,
                AppealSubmitter = "מר חיים לוי",
                PractitionerId = 105,
                Practitioner = "עו\"ד רון כהן",
                StatusId = 1,
                Status = "פתוח"
            },
            new CaseDto
            {
                CaseId = 6,
                CaseNumber = "99001",
                CaseType = "תביעה חוזית",
                CaseTypeId = 6,
                FileOpeningDate = new DateTime(2023, 6, 1),
                EligibilityPeriod = "2023-06-01 עד 2023-07-31",
                CloseDiscussion = new DateTime(2023, 7, 31),
                RespondentProxyId = 206,
                RespondentProxy = "עו\"ד דנה כהן",
                ChairmanCommitteeId = 306,
                ChairmanCommittee = "מר יעקב ישראלי",
                PublicRepresentativeId = 406,
                PublicRepresentative = "גב' רונית לוי",
                AppealSubmitterId = 506,
                AppealSubmitter = "מר יוסי ישראלי",
                PractitionerId = 106,
                Practitioner = "עו\"ד דנה לוי",
                StatusId = 2,
                Status = "סגור"
            },
            new CaseDto
            {
                CaseId = 7,
                CaseNumber = "22334",
                CaseType = "תביעה פלילית",
                CaseTypeId = 2,
                FileOpeningDate = new DateTime(2023, 7, 1),
                EligibilityPeriod = "2023-07-01 עד 2023-12-31",
                CloseDiscussion = new DateTime(2023, 12, 31),
                RespondentProxyId = 207,
                RespondentProxy = "עו\"ד רונית כהן",
                ChairmanCommitteeId = 307,
                ChairmanCommittee = "מר דני ישראלי",
                PublicRepresentativeId = 407,
                PublicRepresentative = "גב' מרים לוי",
                AppealSubmitterId = 507,
                AppealSubmitter = "מר אבי ישראלי",
                PractitionerId = 107,
                Practitioner = "עו\"ד רונית לוי",
                StatusId = 1,
                Status = "פתוח"

       } };
            return cases;
                }
    }
    
    
}
    
