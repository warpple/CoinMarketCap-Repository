﻿using Newtonsoft.Json;

namespace RepoWebAPI.Entities
{
    public class Quote
    {
        public long Id { get; set; }
        
        [JsonProperty("USD")]
        public Usd Usd { get; set; }

        [JsonProperty("DKK")]
        public Dkk Dkk { get; set; }

        [JsonProperty("EUR")]
        public Eur Eur { get; set; }

        [JsonProperty("ZAR")]
        public Zar Zar { get; set; }
    }
}