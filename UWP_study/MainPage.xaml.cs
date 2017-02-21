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

namespace UWP_study
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = !mainview.IsPaneOpen;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbox1.Text = tbox2.Text = tbox3.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                tbox3.Text = (int.Parse(tbox1.Text) + int.Parse(tbox2.Text)).ToString();
            }
            catch(Exception)
            {
                tbox3.Text = "输入错误";
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var dlg = new Windows.UI.Popups.MessageDialog("测试消息弹框!!")
            {
                Title = "测试标题"
            };
            Windows.UI.Popups.UICommandInvokedHandler fun = async uicmd =>
             {
                 var tdlg = new Windows.UI.Popups.MessageDialog("")
                 {
                     Title = "说明",
                     Content = $"您点击了{uicmd.Label}"
                 };
                 tdlg.Commands.Add(new Windows.UI.Popups.UICommand("确定"));
                 await tdlg.ShowAsync();
             };
            dlg.Commands.Add(new Windows.UI.Popups.UICommand("确定",fun));
            dlg.Commands.Add(new Windows.UI.Popups.UICommand("取消", fun));
            await dlg.ShowAsync();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }
    }
}
