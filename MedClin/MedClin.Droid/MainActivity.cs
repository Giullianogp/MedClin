using Android.App;
using Android.Content.PM;
using Android.Graphics.Drawables;
using Android.OS;
using MedClin.Core;
using Microsoft.Azure.Mobile;
using Plugin.Permissions;

namespace MedClin.Droid
{
    [Activity(Label = "MedClin", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.SetIcon(new ColorDrawable(Android.Graphics.Color.Transparent));
            Xamarin.Forms.Forms.Init(this, bundle);
            MobileCenter.Configure("8a6dba55-cceb-4fcb-8a95-13b1461cd023");
            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }


}

