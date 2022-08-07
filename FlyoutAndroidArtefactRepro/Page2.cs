using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace FlyoutAndroidArtefactRepro
    {
    public class Page2 :ContentPage
        {
        public Page2()
            {
            Title="Page 2";
            BackgroundColor=Colors.Black;
            Label page2Label = new Label
                {
                HorizontalTextAlignment=TextAlignment.Center,
                VerticalTextAlignment=TextAlignment.Center,
                };
            page2Label.TextColor=Color.FromArgb("00CC00");
            page2Label.Text="Page 2";
            Content=page2Label;
            }
        }
    }