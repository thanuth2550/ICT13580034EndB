using System;

using Xamarin.Forms;

namespace ICT13580034EndB
{
    public class ProductNewPage : ContentPage
    {
        public ProductNewPage()
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

