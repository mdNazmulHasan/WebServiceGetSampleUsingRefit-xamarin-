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
using Refit;
using System.Threading.Tasks;

namespace App1
{
    interface AnimeApi
    {
        [Get("/api/anime/1")]
        Task<Anime> GetAnimeInfo();
    }
}