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
using Newtonsoft.Json;

namespace App1
{
    class Anime
    {
        [JsonProperty("genre")]
        public string[][] Genre { get; set; }

        [JsonProperty("premiered")]
        public string Premiered { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("aired")]
        public string Aired { get; set; }

        [JsonProperty("broadcast")]
        public string Broadcast { get; set; }

        [JsonProperty("episodes")]
        public long Episodes { get; set; }

        [JsonProperty("ending-theme")]
        public string[] EndingTheme { get; set; }

        [JsonProperty("favorites")]
        public long Favorites { get; set; }

        [JsonProperty("link-canonical")]
        public string LinkCanonical { get; set; }

        [JsonProperty("japanese")]
        public string Japanese { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("licensor")]
        public string[][] Licensor { get; set; }

        [JsonProperty("opening-theme")]
        public string[] OpeningTheme { get; set; }

        [JsonProperty("members")]
        public long Members { get; set; }

        [JsonProperty("popularity")]
        public long Popularity { get; set; }

        [JsonProperty("related")]
        public Related Related { get; set; }

        [JsonProperty("studio")]
        public string[] Studio { get; set; }

        [JsonProperty("ranked")]
        public long Ranked { get; set; }

        [JsonProperty("producer")]
        public string[] Producer { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("score")]
        public double[] Score { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("title-english")]
        public string TitleEnglish { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}