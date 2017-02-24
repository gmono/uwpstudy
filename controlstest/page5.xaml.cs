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
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace controlstest
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class page5 : Page
    {
        public page5()
        {
            this.InitializeComponent();
        }

        private async void Polyline_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var dlg = new MessageDialog("三角形tapped", "提示..");
            dlg.Commands.Add(new UICommand("确定"));
            await dlg.ShowAsync();
        }
    }
}
