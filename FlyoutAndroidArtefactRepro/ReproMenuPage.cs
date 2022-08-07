using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace FlyoutAndroidArtefactRepro
    {
    public class ReproMenuPage :ContentPage
        {
        ListView _itemsView;
        public ListView Items { get { return _itemsView; } }
//// Commented out code is unsuccessful attempt at using CollectionView instead of ListView in Flyout Menu Page
        //CollectionView _items;
        //public CollectionView Items{get{return _items;}}
        #region constructor
        public ReproMenuPage()
            {
            List<MenuItem> menuItemsList = new List<MenuItem>();
            menuItemsList.Add(new MenuItem
                {
                TargetHeading="⌂ Home Page",
                TargetType=typeof(HomePage),
                });
            menuItemsList.Add(new MenuItem
                {
                TargetHeading="Page 2",
                TargetType=typeof(Page2),
                });
            _itemsView=new ListView
                {
                ItemsSource=menuItemsList,
                ItemTemplate=new DataTemplate(() =>
                {
                    Grid grid = new Grid { Padding=new Thickness(5,10) };
                    Label itemLabel = new Label();
                    itemLabel.SetBinding(Label.TextProperty,"TargetHeading");
                    grid.Add(itemLabel,0,0);
                    return new ViewCell { View=grid };
                }),
                SeparatorVisibility=SeparatorVisibility.None,
                };
            Title="Template Menu";
            Padding=new Thickness(0,0,40,0);
            Content=_itemsView;

            //    MenuItem[] menuItems=new MenuItem[2];
            //    menuItems[0]=new MenuItem{
            //        TargetHeading="⌂ Home Page",
            //        TargetType=typeof(HomePage),
            //        };
            //    menuItems[1]=new MenuItem{
            //        TargetHeading="Page 2",
            //        TargetType=typeof(Page2),
            //        };
            //    _items=new CollectionView {
            //        ItemsSource=menuItems,
            //        ItemTemplate=new DataTemplate(()=>{
            //            Grid grid=new Grid{Padding=new Thickness(5,10)};
            //            grid.ColumnDefinitions.Add(new ColumnDefinition{Width=new GridLength(30,GridUnitType.Absolute)});
            //            grid.ColumnDefinitions.Add(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
            //            Label itemLabel=new Label{
            //                FontSize=20,
            //                FontAttributes=FontAttributes.Bold,
            //                Margin=new Thickness(20,0),
            //                };
            //            itemLabel.SetBinding(Label.TextProperty,"TargetHeading");
            ////            grid.Children.Add(itemLabel);
            //            grid.Add(itemLabel,1);
            //            return new ViewCell{View=grid};
            //            }),
            //        };
            //    Title="Template Menu";
            ////    Padding=new Thickness(0,0,40,0);
            //    Content=_items;
            }
        #endregion
        }
    }