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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = !mainview.IsPaneOpen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }
        private Type[] pages = new Type[] { typeof(page2), typeof(page3),typeof(page4),typeof(page5) };
        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox box = sender as ListBox;
            ListBoxItem item = box.SelectedItem as ListBoxItem;
            string text = item.Content as string;
            //弹出对话框
            MessageDialog dlg = new MessageDialog(text, "提示!");
            UICommand cmd = new UICommand("确定并跳转到页"+box.SelectedIndex+1);
            dlg.Commands.Add(cmd);
            await dlg.ShowAsync();
            //跳转
            try
            {
                Type pageptype = pages[box.SelectedIndex];
                pageframe.Navigate(pageptype);
            }
            catch(IndexOutOfRangeException)
            {
                MessageDialog edlg = new MessageDialog("页索引超界", "提示");
                edlg.Commands.Add(new UICommand("确定"));
                await edlg.ShowAsync();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(pageframe.CanGoForward)
            {
                pageframe.GoForward();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(pageframe.CanGoBack)
            {
                pageframe.GoBack();
            }
        }
    }
}
