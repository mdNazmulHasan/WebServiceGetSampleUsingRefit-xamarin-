using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace App1
{
        using Newtonsoft.Json;


        public class Related
        {
            [JsonProperty("Side story")]
            public string[][] SideStory { get; set; }

            [JsonProperty("Adaptation")]
            public string[][] Adaptation { get; set; }

            [JsonProperty("Summary")]
            public string[] Summary { get; set; }
        }
    }
