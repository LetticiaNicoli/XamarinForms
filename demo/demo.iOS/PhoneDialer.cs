using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(demo.iOS.PhoneDialer))]
namespace demo.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}