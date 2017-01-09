
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace Settings.Droid
{
    [Activity(Label = "Settings.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static ISharedPreferences Prefs { get; set; }
        public static Activity Active { get; private set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Prefs = GetSharedPreferences("MyPrefs", FileCreationMode.Private);
            Active = this;
            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}
