using Android.App;
using Android.Widget;
using Android.OS;
using Refit;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private AnimeApi otherApi;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Toast.MakeText(this, "Sample Message", ToastLength.Long).Show();
             otherApi = RestService.For<AnimeApi>("http://jikan.me",
    new RefitSettings
    {
        JsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        }
    });
            GetAnimeInfo();

        }
        private async void GetAnimeInfo()
        {
            try
            {
                var animeInfo = await otherApi.GetAnimeInfo();
                Toast.MakeText(this, animeInfo.Aired, ToastLength.Long).Show();


            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.StackTrace, ToastLength.Long).Show();

            }
        }

    }
}

