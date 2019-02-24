using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Urho;
using Urho.Droid;
using UrhoSharp.Toolkit.Demo;

namespace UrhoSharp.Toolkit.DroidDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private DemoGame app;
        private UrhoSurfacePlaceholder surface;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var mLayout = new AbsoluteLayout(this);
            surface = UrhoSurface.CreateSurface(this); // (this, , true);
            mLayout.AddView(surface);
            SetContentView(mLayout);
            app = (DemoGame) await surface.Show(typeof(DemoGame), new ApplicationOptions("Data"));
        }

        protected override void OnResume()
        {
            UrhoSurface.OnResume();
            base.OnResume();
        }

        protected override void OnPause()
        {
            UrhoSurface.OnPause();
            base.OnPause();
        }

        public override void OnLowMemory()
        {
            UrhoSurface.OnLowMemory();
            base.OnLowMemory();
        }

        protected override void OnDestroy()
        {
            UrhoSurface.OnDestroy();
            base.OnDestroy();
        }

        //public override void OnBackPressed()
        //{
        //    if (app.GoBackIfPossible())
        //    {
        //        return;
        //    }
        //    base.OnBackPressed();
        //}

        public override bool DispatchKeyEvent(KeyEvent e)
        {
            if (e.KeyCode == Keycode.Back)
                if (app.Navigation.StackSize > 1)
                {
                    Task.Run(() => app.Navigation.GoBackAsync());
                    return true;
                }

            if (!UrhoSurface.DispatchKeyEvent(e))
                return false;

            return base.DispatchKeyEvent(e);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            UrhoSurface.OnWindowFocusChanged(hasFocus);
            base.OnWindowFocusChanged(hasFocus);
        }
    }
}