﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PS.Mothership.Core.Common.Enums.EchoSign
{
    [DataContract]
    public enum AgreementStatusEnum
    {
        [EnumMember]
        ABORTED,
        [EnumMember]
        EXPIRED,
        [EnumMember]
        SIGNED,
        [EnumMember]
        WAITING_FOR_MY_APPROVAL,
        [EnumMember]
        OTHER,
        [EnumMember]
        OUT_FOR_SIGNATURE,
        [EnumMember]
        ARCHIVED,
        [EnumMember]
        UNKNOWN,
        [EnumMember]
        APPROVED,
        [EnumMember]
        HIDDEN,
        [EnumMember]
        WAITING_FOR_AUTHORING,
        [EnumMember]
        WAITING_FOR_MY_SIGNATURE,
        [EnumMember]
        WIDGET,
        [EnumMember]
        OUT_FOR_APPROVAL,
        [EnumMember]
        RECALLED,
        [EnumMember]
        FORM,
        [EnumMember]
        NOT_YET_VISIBLE,
        [EnumMember]
        IN_REVIEW,
        [EnumMember]
        WAITING_FOR_MY_REVIEW,
        [EnumMember]
        PARTIAL,
        [EnumMember]
        WAITING_FOR_FAXIN
    }
}
