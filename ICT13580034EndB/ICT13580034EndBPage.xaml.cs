using Xamarin.Forms;

namespace ICT13580034EndB
{
    public partial class ICT13580034EndBPage : ContentPage
    {
        public ICT13580034EndBPage()
        {
			InitializeComponent();

            newButton.Clicked += NewButton_Clicked;
		}


        void NewButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new ProductNewPage());
        }
    }
}
