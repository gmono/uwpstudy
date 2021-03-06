﻿using System;
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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace dingcan
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Gouwu : Page
    {
        public Gouwu()
        {
            this.InitializeComponent();
            this.pageframe.Navigate(typeof(EatPage));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pageframe.Navigate(typeof(EatPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pageframe.Navigate(typeof(DrinkPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pageframe.Navigate(typeof(TimePage));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pageframe.Navigate(typeof(CompletePage));
        }
    }
}
