using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class Attachment
    {
        public string Filename { get; set; }
        public string FileBlob_Base64 { get; set; }
        public string MimeType { get; set; }

        public Attachment(string fileName, string fileBlob, string mimeType)
        {
            Filename = fileName;
            FileBlob_Base64 = fileBlob;
            MimeType = mimeType;
        }
    }
}
