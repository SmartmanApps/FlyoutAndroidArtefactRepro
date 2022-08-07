using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace FlyoutAndroidArtefactRepro
    {
    public class HomePage :ContentPage
        {
        public HomePage()
            {
            Title="⌂ Home Page";
            BackgroundColor=Colors.Black;
            Label mainpageLabel = new Label
                {
                HorizontalTextAlignment=TextAlignment.Center,
                VerticalTextAlignment=TextAlignment.Center,
                };
            mainpageLabel.TextColor=Color.FromArgb("00CC00");
            mainpageLabel.Text="⌂ Home Page";
            Content=mainpageLabel;
            }
        }
    }