using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for SubscribeForm.xaml
    /// </summary>
    public partial class SubscribeForm : Window
    {
        private MainWindow mainWindow;
        public SubscribeForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void submitForm(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(FullName.Text) || String.IsNullOrWhiteSpace(EmailAddress.Text))
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Please enter value for fields";
                FullName.Focus();
            }
            else
            {
                MessageBox.Show("Thank you! You have now been subscribed to our newsletter!");
                mainWindow.Show();
                Hide();
            }
        }
    }
}
