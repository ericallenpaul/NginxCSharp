using System;
using System.Collections.Generic;
using System.Text;

namespace NginxCSharp.Enums
{
    public enum NginxHTTPUpstreamPeerState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"up")]
        Up = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"draining")]
        Draining = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"down")]
        Down = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"unavail")]
        Unavail = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"checking")]
        Checking = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"unhealthy")]
        Unhealthy = 5,

    }


    public enum NginxStreamUpstreamPeerState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"up")]
        Up = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"down")]
        Down = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"unavail")]
        Unavail = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"checking")]
        Checking = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"unhealthy")]
        Unhealthy = 4,

    }
}
