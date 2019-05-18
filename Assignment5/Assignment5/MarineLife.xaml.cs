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
    /// Interaction logic for MarineLife.xaml
    /// </summary>
    public partial class MarineLife : Window
    {
        private MainWindow mainWindow;

        public MarineLife(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }
    }
}
