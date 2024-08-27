using Case.BL.Services.Interfaces;
using CaseService.DAL.Repositories;
using Messaging.Interfaces;
using Shared.Messaging;
using Shred.Models.DTO;
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
    }
}