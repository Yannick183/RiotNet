﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RiotNet
{
    /// <summary>
    /// Contains settings for a <see cref="RiotClient"/>.
    /// </summary>
    public class RiotClientSettings
    {
        /// <summary>
        /// Gets the JsonSerializerSettings that are used for requests to the Riot API if no other settings are explicitly specified. 
        /// </summary>
        /// <returns>The JsonSerializerSettings.</returns>
        private static JsonSerializerSettings GetDefaultJsonSettings()
        {
            return new JsonSerializerSettings
            {
                ContractResolver = new RiotNetContractResolver(),
                MissingMemberHandling = MissingMemberHandling.Ignore,
            };
        }

        /// <summary>
        /// Creates a new <see cref="RiotClientSettings"/> instance.
        /// </summary>
        public RiotClientSettings()
        {
            RetryOnTimeout = false;
            RetryOnConnectionFailure = false;
            RetryOnRateLimitExceeded = true;
            ThrowOnError = true;
            JsonFormatting = Formatting.None;
            JsonSettings = GetDefaultJsonSettings();
        }

        /// <summary>
        /// Gets or sets a function that defines the default settings.
        /// </summary>
        public static Func<RiotClientSettings> Default { get; set; }

        /// <summary>
        /// Gets or sets the Riot API key to use.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets how the <see cref="RiotClient"/> should handle the case where the request times out.
        /// </summary>
        public bool RetryOnTimeout { get; set; }

        /// <summary>
        /// Gets or sets how the <see cref="RiotClient"/> should handle the case where the client fails to connect to the server.
        /// </summary>
        public bool RetryOnConnectionFailure { get; set; }

        /// <summary>
        /// Gets or sets how the <see cref="RiotClient"/> should handle the case where the rate limit is exceeded.
        /// </summary>
        public bool RetryOnRateLimitExceeded { get; set; }

        /// <summary>
        /// Gets or sets whether the client should throw an exception if an error occurred during the request (that is, the request did not complete, or it completed with a response code of 400 or higher).
        /// </summary>
        public bool ThrowOnError { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of times that the same request should be attempted. Applies only if one of the RequestErrorHandling modes is set to Retry.
        /// </summary>
        public int MaxRequestAttempts { get; set; }

        /// <summary>
        /// Gets or sets the settings to use for serialization and deserialization.
        /// </summary>
        public JsonSerializerSettings JsonSettings { get; set; }

        /// <summary>
        /// Gets or sets the formatting to use for JSON serialization.
        /// </summary>
        public Formatting JsonFormatting { get; set; }
    }
}