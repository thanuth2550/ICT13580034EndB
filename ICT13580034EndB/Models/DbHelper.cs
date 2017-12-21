using System;

using Xamarin.Forms;

namespace ICT13580034EndB.Helpers
{
    public class DbHelper : ContentPage
    {
        public DbHelper()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

