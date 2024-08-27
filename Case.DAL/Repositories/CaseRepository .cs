using Shred.Models.DTO;

namespace CaseService.DAL.Repositories
{
    public class CaseRepository : ICaseRepository
    {
        public CaseDto CreateCase(CaseDto caseDto)
        {
            // לוגיקה ליצירת תיק בבסיס הנתונים
            return caseDto; // החזרת התיק שנוצר עם המזהה שנוצר
        }
    }
}