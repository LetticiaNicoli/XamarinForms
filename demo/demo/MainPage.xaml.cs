﻿using System;
using Xamarin.Forms;

namespace demo
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnTranslate(object sender, EventArgs e)
        {
            translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }

        async void OnCall(object sender, EventArgs e)
        {
            var dialer = DependencyService.Get<IDialer>();
            if (dialer != null)
            {
                App.PhoneNumbers.Add(translatedNumber);
                callHistoryButton.IsEnabled = true;
                dialer.Dial(translatedNumber);
            }

        }

        async void OnCallHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallHistoryPage());
        }

        async void OnCallAnimation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallAnimationPage());
        }

    }
}
