using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace pagenav
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            myframe.Navigate(typeof(Page1));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if(myframe.CanGoBack)
            {
                myframe.GoBack();
            }
            else
            {
                var dlg = new MessageDialog("已经后退到头了……", "提示");
                dlg.Commands.Add(new UICommand("确定"));
                await dlg.ShowAsync();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = !mainview.IsPaneOpen;
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (myframe.CanGoForward)
            {
                myframe.GoForward();
            }
            else
            {
                var dlg = new MessageDialog("已经前进到头了……", "提示");
                dlg.Commands.Add(new UICommand("确定"));
                await dlg.ShowAsync();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(Page1));
            mainview.IsPaneOpen = false;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(Page2));
            mainview.IsPaneOpen = false;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(Page3));
            mainview.IsPaneOpen = false;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = false;
        }
    }
}
