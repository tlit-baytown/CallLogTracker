using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class TemplateData
    {
        [JsonProperty("caller_name")]
        public string CallerName { get; set; } = "";

        [JsonProperty("subject")]
        public string Subject { get; set; } = "";

        [JsonProperty("answerer")]
        public string Answerer { get; set; } = "";

        [JsonProperty("call_back")]
        public string CallBackNumber { get; set; } = "";

        [JsonProperty("email")]
        public string EmailAddress { get; set; } = "";

        [JsonProperty("message")]
        public string Message { get; set; } = "";

        [JsonProperty("timestamp")]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public string ToSMSMessage()
        {
            StringBuilder bldr = new StringBuilder();
            bldr.Append("An important phone call has happened while you were out.").Append("\n");
            bldr.Append($"Call Taken By: {Answerer}\n");
            bldr.Append($"Caller: {CallerName}\n");
            bldr.Append($"Caller Email: {EmailAddress}\n");
            bldr.Append($"CallBack: {CallBackNumber}\n");
            bldr.Append($"Message: {Message}\n");
            return bldr.ToString();
        }
    }
}
