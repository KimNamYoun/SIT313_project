using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.Views.InputMethods;
using Android.Util;
using AlertDialog = Android.App.AlertDialog;

namespace Project_1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.content_main);
            var bt = FindViewById<Button>(Resource.Id.button1);
            bt.Click += BtOnClick;
        }

        private void BtOnClick(object sender, EventArgs e)
        {
            StartActivity(new Intent(Application.Context, typeof(MenuActivity)));
        }
    }
}

