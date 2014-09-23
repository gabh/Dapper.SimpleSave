﻿using PS.Mothership.Core.Common.Template.Gen;
using System;
using System.Runtime.Serialization;

namespace PS.Mothership.Core.Common.Dto.Merchant
{
    [DataContract]
    public class TypeOfTransactionDto
    {
        [DataMember]
        public int TypeOfTransactionKey { get; set; }

        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public Guid RowGuid { get; set; }

        [DataMember]
        public GenRecStatusEnum RecStatusKey { get; set; }

        [DataMember]
        public int FieldItemKey { get; set; }
    }
}