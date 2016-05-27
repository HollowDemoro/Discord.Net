﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Discord.API.Gateway
{
    public class IdentifyCommand
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("properties")]
        public IDictionary<string, string> Properties { get; set; }
        [JsonProperty("large_threshold")]
        public int LargeThreshold { get; set; }
        [JsonProperty("compress")]
        public bool UseCompression { get; set; }
    }
}
