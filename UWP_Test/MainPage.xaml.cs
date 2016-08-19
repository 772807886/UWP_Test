﻿using Windows.UI.Xaml.Controls;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWP_Test {
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ToastInput_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            ToastInput toastInput = new ToastInput();
            toastInput.display();
        }
    }
}
