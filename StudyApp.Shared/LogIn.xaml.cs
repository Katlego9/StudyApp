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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StudyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogIn : Page
    {
        public LogIn()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var objLogin = new MemberViewModel();

            string name = string.Empty;
            string pass = string.Empty;
            name = txbName.Text;
            pass = txbPassword.Text;

            try
            {
                var confirm = objLogin.getMember(name,pass);
                if (confirm != null)
                {
                    this.Frame.Navigate(typeof(MainPage));
                }
                else
                {
                    txtoutput.Text = "Not successful.";
                }
            }
            catch (Exception)
            {
                txtoutput.Text = "Not successful.";
            }
           
  
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }
    }
}
