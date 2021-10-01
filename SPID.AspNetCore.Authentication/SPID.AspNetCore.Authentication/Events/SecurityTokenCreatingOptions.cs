﻿using System.Security.Cryptography.X509Certificates;

namespace SPID.AspNetCore.Authentication.Events
{
    public sealed class SecurityTokenCreatingOptions
    {
        public string EntityId { get; set; }
        public string AssertionConsumerServiceURL { get; set; }
        public ushort? AssertionConsumerServiceIndex { get; set; }
        public ushort AttributeConsumingServiceIndex { get; set; }
        public X509Certificate2 Certificate { get; set; }
    }
}
