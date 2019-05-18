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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool mainNarratorFlag;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAmphibiansLink1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Amphibians amphibiansWin = new Amphibians(this);
            amphibiansWin.Show();
        }

        private void BtnClassificationLink1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Classification classificationWin = new Classification(this);
            classificationWin.Show();
        }

        private void BtnMammalsLink1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Mammals mammalsWin = new Mammals(this);
            mammalsWin.Show();
        }

        private void BtnBirdsLink1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Birds birdsWin = new Birds(this);
            birdsWin.Show();
        }

        private void BtnReptilesLink1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reptiles reptilesWin = new Reptiles(this);
            reptilesWin.Show();
        }

        private void BtnFishLink1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MarineLife marineLifeWin = new MarineLife(this);
            marineLifeWin.Show();
        }
    }
}
