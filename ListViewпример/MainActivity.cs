using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace ListViewпример
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView result;
        String[] names = { "Diana", "Anna", "Denis", "Tatyana", "Andrey" };
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            SetContentView(Resource.Layout.activity_main);

            result = FindViewById<ListView>(Resource.Id.result);

            ArrayAdapter<String> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, names);

            result.Adapter = adapter;
        }
    }
}