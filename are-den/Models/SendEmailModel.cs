using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace are_den.Models
{
    public class SendEmailModel
    {
        public string contact_name { get; set; }
        public string contact_email { get; set; }
        public string contact_phone { get; set; }
        public string contact_message { get; set; }

    }
}