using System;
using Newtonsoft.Json;

namespace DSharpPlus.Entities
{
    public class DiscordReadState : SnowflakeObject
    {
        [JsonProperty("mention_count")]
        public int MentionCount { get; internal set; }

        [JsonProperty("last_message_id")]
        public ulong LastMessageId { get; internal set; }

        [JsonProperty("last_pin_timestamp")]
        public DateTimeOffset? LastPinTimestamp { get; internal set; }
    }
}