using AcunMedyaAkademiPortfolio.Models;
using System.Collections.Generic;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class PartialViewModel
    {
        public List<TblService> Table1Data { get; set; }
        public List<TblProfile> Table2Data { get; set; }
        public List<TblSocialMedia> Table3Data { get; set; }
    }
}