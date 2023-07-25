using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InfoSystem
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            var mySettings = new MetroDialogSettings
            {
                AffirmativeButtonText = "종료",
                NegativeButtonText = "취소",
                AnimateShow = true,
                AnimateHide = true
            };

            var result = await this.ShowMessageAsync("프로그램을 종료", "프로그램을 종료하시겠습니까?",
                                                     MessageDialogStyle.AffirmativeAndNegative, mySettings);
            Process.GetCurrentProcess().Kill();
        }

        private void MnuNew_Click(object sender, RoutedEventArgs e)
        {
            var newPerson = new Views.Info.NewPerson2();
            ActiveItem.Content = newPerson;
            StsSelScreen.Content = "신규등록";
        }

        private void MnuSelect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnuExitProgram_Click(object sender, RoutedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
