﻿using Newtonsoft.Json;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines a country info class.
    /// </summary>
    public class CountryInfo
    {
        /// <summary>
        /// Gets or sets the Iso2.
        /// </summary>
        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        /// <summary>
        /// Gets or sets the Iso3.
        /// </summary>
        [JsonProperty("iso3")]
        public string Iso3 { get; set; }

        /// <summary>
        /// Gets or sets the Latitude.
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the Longitude.
        /// </summary>
        [JsonProperty("long")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the country flag Url.
        /// </summary>
        [JsonProperty("flag")]
        public string FlagUrl { get; set; }
    }
}
