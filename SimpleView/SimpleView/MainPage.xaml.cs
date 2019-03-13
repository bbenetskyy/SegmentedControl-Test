using Xamarin.Forms;

namespace SimpleView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SegControl_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            infoLabel.Text = $"Selected #{SegControl.SelectedSegment+1} Tab!";
        }
    }
}
