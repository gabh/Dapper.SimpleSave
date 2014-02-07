﻿using PS.Mothership.Core.Common.Template.Dial;
using System;
using System.Runtime.Serialization;

namespace PS.Mothership.Core.Common.Rellaid.Dto
{
    [DataContract]
    public class NewDiallerCallDto
    {
        [DataMember]
        public Guid MothershipSessionGuid { get; set; }

        [DataMember]
        public Guid SipCallGuid { get; set; }

        [DataMember]
        public CallTypeEnum CallType { get; set; }

        [DataMember]
        public Guid SessionModeGuid { get; set; }

        [DataMember]
        public DateTime StartDateTime { get; set; }

        [DataMember]
        public string DialledNumber { get; set; }

        [DataMember]
        public string UserPhoneNumber { get; set; }

        [DataMember]
        public string CIDNumber { get; set; }

        [DataMember]
        public Guid? MerchantGuid { get; set; }

        [DataMember]
        public Guid? ProspectingCampaignCallGuid { get; set; }

        [DataMember]
        public long? CampaignKey { get; set; }

        [DataMember]
        public Guid? ConsultOriginSipCallGuid { get; set; }

        [DataMember]
        public Guid? ProspectingCampaignResponseTapCallGuid { get; set; }

        [DataMember]
        public Guid? InboundCampaignCallGuid { get; set; }

        [DataMember]
        public CallDispositionEnum CallDisposition { get; set; }
    }
}
