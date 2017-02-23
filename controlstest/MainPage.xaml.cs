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

namespace controlstest
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            pageframe.Navigate(typeof(page2));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = !mainview.IsPaneOpen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }
        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox box = sender as ListBox;
            ListBoxItem item = box.SelectedItem as ListBoxItem;
            string text = item.Content as string;
            //弹出对话框
            MessageDialog dlg = new MessageDialog(text, "提示!");
            UICommand cmd = new UICommand("确定");
            dlg.Commands.Add(cmd);
            await dlg.ShowAsync();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pageframe.Navigate(typeof(page3));
        }
    }
}
