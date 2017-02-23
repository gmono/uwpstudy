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
        private void updatetext()
        {
            viewtext.Text = "";
            foreach(var s in seleset)
            {
                viewtext.Text += s;
            }
        }
        private List<string> seleset = new List<string>();
        private void CheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBox cbox = sender as CheckBox;
            if(cbox.IsChecked==true)
            {
                if(!seleset.Contains(cbox.Content as string))
                {
                    seleset.Add(cbox.Content as string);
                }
                
            }
            else
            {
                if(seleset.Contains(cbox.Content as string))
                {
                    seleset.Remove(cbox.Content as string);
                }
            }
            updatetext();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            rviewtext.Text = btn.Content as string;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBox cbox = sender as ComboBox;
                ComboBoxItem item = cbox.SelectedItem as ComboBoxItem;
                cboxview.Text = item.Content as string;
                //这里在启动时会出现一个错误 即因为设置了isselect（或者 ischecked之类的） 初始化时会产生一个change事件
                //这里 调试中出现null错误 但是 调试器中看到的是hello字符串 原因不明
            }
            catch(Exception)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainview.IsPaneOpen = !mainview.IsPaneOpen;
        }

        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox box = sender as ListBox;
            ListBoxItem item = box.SelectedItem as ListBoxItem;
            string text = item.Content as string;
            //弹出对话框
            MessageDialog dlg = new MessageDialog(text,"提示!");
            UICommand cmd = new UICommand("确定");
            dlg.Commands.Add(cmd);
            await dlg.ShowAsync();
        }

        private async void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton tbtn = sender as ToggleButton;
            if(tbtn.IsChecked==true)
            {
                MessageDialog dlg = new MessageDialog("选中", "提示！！！");
                UICommand cmd = new UICommand("hello world");
                dlg.Commands.Add(cmd);
                await dlg.ShowAsync();
            }
        }

        private void ToggleButton_Click_1(object sender, RoutedEventArgs e)
        {
            ToggleButton btn = sender as ToggleButton;
            if(btn.IsChecked==null)
            {
                threeview.Text = "空(ischecked=null)";
            }
            else
            {
                threeview.Text = btn.IsChecked.ToString();
            }
        }



        private async void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            var twobj = sender as ToggleSwitch;
            var dlg = new MessageDialog(twobj.IsOn.ToString(), "提示。。");
            dlg.Commands.Add(new UICommand("确定"));
            await dlg.ShowAsync();
        }

        private async void TimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            TimePicker tpk = sender as TimePicker;
            var dlg = new MessageDialog(tpk.Time.ToString(), "选择时间");
            dlg.Commands.Add(new UICommand("ok"));
            await dlg.ShowAsync();
        }
    }
}
