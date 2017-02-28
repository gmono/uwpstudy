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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace dingcan
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.mainframe.Navigate(typeof(Gouwu));
        }



        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = !mainview.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //切换页
            ListBox box = sender as ListBox;
            switch(box.SelectedIndex)
            {
                case 0:
                    mainframe.Navigate(typeof(Gouwu));
                    break;
                case 1:
                    mainframe.Navigate(typeof(dingdan));
                    break;
                default:
                    DataStore.ShowMsgbox("错误", "不存在此页面");
                    break;
            }
            mainview.IsPaneOpen = false;
        }
    }
}
