using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace Unique.Id.To.Be.Replaced.Android;

[Activity(Label = "Unique.Id.To.Be.Replaced.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity
{
}
