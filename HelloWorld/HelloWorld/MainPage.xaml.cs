using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.VisualBasic;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace HelloWorld
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Hello world").ShowAsync();
        }


        //private void Show_Click(object sender, RoutedEventArgs e)
        //{
        //    Hide.Visibility = Hide.Visibility.Equals(Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
        //}

        public SL sl =new SL();

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Email.Text = string.Empty;
            Website.Text = string.Empty;
            Telephone.Text = string.Empty;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Email.Text = sl.LoadSetting("Email");
            Website.Text = sl.LoadSetting("website");
            Telephone.Text = sl.LoadSetting("Telephone");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            sl.SaveSetting("Email", Email.Text);
            sl.SaveSetting("Website", Website.Text);
            sl.SaveSetting("Telephone", Telephone.Text);
        }
    }
}
