namespace Websockettorest.DataAccess
{
    using System;
    using Newtonsoft.Json.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Event
    {
        [JsonProperty("machine_id")]
        public string MachineId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EventStatus Status { get; set; }
    }
}
