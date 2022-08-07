using Microsoft.Maui.Controls;

namespace FlyoutAndroidArtefactRepro;

internal class App :Application
    {
    public App()
        {
        MainPage=new ReproFlyoutPage();
        }
    }