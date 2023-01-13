﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CouchDB.Driver.Types
{
    [JsonObject("_replication")]
    public class CouchReplication : CouchDocument
    {
        [DataMember]
        [JsonProperty("source")]
        public object? Source { get; internal set; }

        public CouchReplicationBasicCredentials? SourceCredentials { get; set; }

        [DataMember]
        [JsonProperty("target")]
        public object? Target { get; internal set; }

        public CouchReplicationBasicCredentials? TargetCredentials { get; set; }

        [DataMember]
        [JsonProperty("continuous")]
        public bool Continuous { get; set; }

        [DataMember]
        [JsonProperty("selector")]
        public object? Selector { get; set; }

        [DataMember]
        [JsonProperty("cancel")]
        public bool Cancel { get; internal set; }

        [DataMember]
        [JsonProperty("create_target")]
        public bool CreateTarget { get; set; }
        
        [DataMember]
        [JsonProperty("filter")]
        public string? Filter { get; set; }

        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(100);
    }
}
