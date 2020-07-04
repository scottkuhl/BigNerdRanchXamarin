using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Widget;

namespace GeoQuiz
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _trueButton;
        private Button _falseButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _trueButton = FindViewById<Button>(Resource.Id.true_button);
            _falseButton = FindViewById<Button>(Resource.Id.false_button);

            _trueButton.Click += delegate
            {
                Toast toast = Toast.MakeText(this, Resource.String.correct_toast, ToastLength.Short);
                toast.SetGravity(Android.Views.GravityFlags.Top, 0, 180);
                toast.Show();
            };

            _falseButton.Click += delegate
            {
                Toast toast = Toast.MakeText(this, Resource.String.incorrect_toast, ToastLength.Short);
                toast.SetGravity(Android.Views.GravityFlags.Top, 0, 180);
                toast.Show();
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}