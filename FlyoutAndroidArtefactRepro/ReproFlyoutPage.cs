//using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Linq;

namespace FlyoutAndroidArtefactRepro
    {
    public class ReproFlyoutPage :FlyoutPage
        {
        ReproMenuPage Menu;
        NavigationPage HomePage;
        NavigationPage Page2;
        public ReproFlyoutPage()
            {
            HomePage=new NavigationPage(new HomePage());
            Page2=new NavigationPage(new Page2());
            Menu=new ReproMenuPage();
            Flyout=Menu;
            Detail=HomePage;
            FlyoutLayoutBehavior=FlyoutLayoutBehavior.Popover;
            Menu.Items.ItemSelected+=OnItemSelected;
            //    Menu.Items.SelectionChanged+=Items_SelectionChanged;
            }
        private void Items_SelectionChanged(object sender,SelectionChangedEventArgs e)
            {
            MenuItem selectedItem = e.CurrentSelection.FirstOrDefault() as MenuItem;
            if (selectedItem!=null)
                {
                switch (selectedItem.TargetHeading)
                    {
                    case "⌂ Home Page":
                        Detail=HomePage;
                        break;
                    case "Page 2":
                        Detail=Page2;
                        break;
                    default:
                        break;
                    }
                IsPresented=false;
                }
            }
        private void OnItemSelected(object sender,SelectedItemChangedEventArgs e)
            {
            MenuItem selectedItem = e.SelectedItem as MenuItem;
            if (selectedItem!=null)
                {
                switch (selectedItem.TargetHeading)
                    {
                    case "⌂ Home Page":
                        Detail=HomePage;
                        break;
                    case "Page 2":
                        Detail=Page2;
                        break;
                    default:
                        break;
                    }
                Menu.Items.SelectedItem=null;
                IsPresented=false;
                }
            }
        }
    }