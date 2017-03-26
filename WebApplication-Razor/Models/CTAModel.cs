using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Razor.Models
{
    public class CTAModel
    {
        public string Uri { get; set; }

        public string ImageUri { get; set; }

        public CTAModel(string uri, string imageUri)
        {
            Uri = uri;
            ImageUri = imageUri;
        }
    }
}