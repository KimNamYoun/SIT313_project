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

namespace Project_1
{
    [Activity(Label = "LoginActivity", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            var bt = FindViewById<Button>(Resource.Id.loginButton);
            bt.Click += BtOnClick;

        }

        private void BtOnClick(object sender, EventArgs eventArgs)
        {
            var username = FindViewById<EditText>(Resource.Id.username);
            var password = FindViewById<EditText>(Resource.Id.password);

            if (username.Text == "kim" && password.Text == "pass")
            {
                Toast.MakeText(this, "Login Successful!", ToastLength.Long).Show();
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }
            else
            {
                AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
                alertDialog.SetTitle("Try again!");
                alertDialog.SetMessage("Invalid E-mail or password");
                alertDialog.SetNeutralButton("OK", delegate
                {
                    alertDialog.Dispose();
                });
                alertDialog.Show();
                return;
            }
        }
    }
}