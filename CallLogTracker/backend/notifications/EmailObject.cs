using CallLogTracker.Properties;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class EmailObject
    {
        public List<EmailAddress> To { get; set; } = new List<EmailAddress>();
        public EmailAddress Sender { get; set; }
        public string Subject { get; set; } = "";
        public string TextBody { get; set; } = "";
        public string HTMLBody { get; set; } = "";
        public List<Dictionary<string, string>> CustomHeaders { get; set; } = new List<Dictionary<string, string>>();
        public List<Attachment> Attachments { get; set; } = new List<Attachment>();

        //public string ToJsonRequest()
        //{
        //    StringBuilder builder = new StringBuilder();
        //    builder.Append("{\n\t");
        //    builder.Append($"\"api_key\": \"{Resources.Smtp2Go_ApiKey}\",\n\t");
        //    builder.Append($"\"to\": [\"{To}\"],\n\t");
        //    builder.Append($"\"sender\": \"{Sender}\",\n\t");
        //    builder.Append($"\"subject\": \"{Subject}\",\n\t");
        //    builder.Append($"\"text_body\": \"{TextBody}\",\n\t");
        //    builder.Append($"\"html_body\": \"{HTMLBody}\",\n\t");
        //    builder.Append($"\"custom_headers\": [\n\t\t");
        //    foreach (Dictionary<string, string> dict in CustomHeaders)
        //    {
        //        builder.Append("{\n");
        //        foreach (string key in dict.Keys)
        //        {
        //            builder.Append($"\"header\": \"{key}\",\n\t");
        //            builder.Append($"\"value\": \"{dict[key]}\"\n\t");
        //        }
        //        builder.Append("},\n");
        //    }
        //    builder.Append("],\n\t");
        //    builder.Append($"\"attachments\": [\n\t\t");
        //    foreach (Attachment att in Attachments)
        //    {
        //        builder.Append("{\n\t");
        //        builder.Append($"\"filename\": \"{att.Filename}\"\n\t\t");
        //        builder.Append($"\"fileblob\": \"{att.FileBlob_Base64}\"\n\t\t");
        //        builder.Append($"\"mimetype\": \"{att.MimeType}\"\n\t");
        //        builder.Append("},\n\t");
        //    }
        //    builder.Append("]\n\t");
        //    builder.Append("}");

        //    return builder.ToString();
        //}
    }
}
