﻿using PS.Mothership.Core.Common.Template.Opp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Mothership.Core.Common.Dto.Merchant
{
    public class MerchantOfferDto
    {
        public Guid CustomerGuid { get; set; }

        public Guid OfferGuid { get; set; }

        public string Reference { get; set; }

        public string Description { get; set; }

        public OppOpportunityStatusEnum Status { get; set; }

        public string StatusDescription
        {
            get
            {
                return OppOpportunityStatusCollection.OppOpportunityStatusList.Single(x => x.EnumValue == (long)Status).EnumDescription;
            }
        }

        public double Credit { get; set; }

        public double Debit { get; set; }

        public OppContractLengthEnum Duration { get; set; }

        public string DurationDescription
        {
            get
            {
                return OppContractLengthCollection.OppContractLengthList.Single(x => x.EnumValue == (long)Duration).EnumDescription;
            }
        }

        public DateTimeOffset UpdateDate { get; set; }

        public string UpdateUsername { get; set; }
    }
}
