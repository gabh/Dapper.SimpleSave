﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PS.Mothership.Core.Common.Dto.Roles
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public Guid UserGuid { get; set; }
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<UserAssignedAndAvailableRoleDto> Roles { get; set; }
    }
}
