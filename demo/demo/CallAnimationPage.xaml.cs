
using Xamarin.Forms;

namespace demo
{
    public partial class CallAnimationPage : ContentPage
    {
        public CallAnimationPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await hello.RotateTo(360, 2000);

            //await hello.ScaleTo(2, 1500, Easing.CubicInOut);
            //await hello.ScaleTo(1, 500, Easing.Linear);

            //await hello.TranslateTo(-100, -100, 1000);
        }
    }
}
