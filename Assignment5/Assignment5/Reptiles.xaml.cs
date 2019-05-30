using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for Reptiles.xaml
    /// </summary>
    public partial class Reptiles : Window
    {
        private MainWindow mainWindow;

        public Reptiles(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }

        private void BtnSpinySoftShellTurtle_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Spiny softshell turtles have soft, flat, rounded carapaces (shells) without large scales. The edges are soft with small spines. The nose is long and upturned. The underbelly is whitish or yellow with bones visible underneath. They have claws and their feet are webbed for swimming. The body is olive or tan with black speckles and a dark rim around the edge of their shell. Adult males have olive and yellow coloration on their carapaces, with black 'eyespots', and a thicker tail tham females. Males are also smaller than females, with a shell length of 12.7 to 24 cm. Females are 24 to 48 cm in length, with dark carapace and a small tail that doesn't go beyond the edge of their carapaces.");
        }

        private void BtnGreenIguana_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Green Iguanas are arboreal lizards that live high in the tree canopy. Juveniles establish areas lower in the canopies while older mature iguanas reside higher up. This tree dwelling habit allows them to bask in the sun, rarely coming down except when females dig burrows to lay eggs. Although preferring an arboreal (forested) environment, they can adjust well to a more open area. No matter where they inhabit, they prefer to have water around as they are excellent swimmers and will dive beneath the water to avoid predators.");
        }

        private void BtnWhiteBelliedWormWizard_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("White-bellied Worm Lizard is not a snake but a species of Amphisbaenian or worm lizard found throughout South America. Other than their obvious lack of limbs these reptiles live similar lives to their lizard relatives. Moving their loose skin in an accordion-like motion to move around and hunt for their prey.");
        }

        private void BtnCrocodile_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reaching lengths of more than 23 feet (6.5 m) and weights over 2,200 pounds (~1,000 kilos), the saltwater crocodile is the largest reptile on the planet and is a formidable predator throughout its range. Saltwater crocodiles of this size are capable of eating just about any animal that strays too close and are particularly adept at drowning terrestrial creatures like birds and mammals. Named for its ability to survive in full salinity seawater, saltwater crocodiles typically live in brackish (low salinity) water near the coast.");
        }

        private void BtnTuatara_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tuatara are rare, medium-sized reptiles found only in New Zealand. They are the last survivors of an order of reptiles that thrived in the age of the dinosaurs. All species except the tuatara declined and eventually became extinct about 60 million years ago!");
        }

        private void BtnRattlesnake_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The eastern diamondback rattlesnake is North America's longest, heaviest venomous snake, averaging 3-6 feet long, with some adults growing up to 8 feet. It's known for its iconic rattle and its venomous bite, which can be fatal to humans. The eastern diamondback rattlesnake can be blackish-gray, olive green or muddy gray. This species is easily identified by the diamond-shaped pattern along its back, as well as the distinctive black band that covers its eyes, outlined by two pale lines. It has vertical, cat-like pupils, and there is a large pit between the nostril and the eye on each side of its face.");
        }

        private void BtnSeaTurtle_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Leatherbacks are the largest turtles on Earth, growing up to seven feet long and exceeding 2,000 pounds. These reptilian relics are the only remaining representatives of a family of turtles that traces its evolutionary roots back more than 100 million years. Once prevalent in every ocean except the Arctic and Antarctic, the leatherback population is rapidly declining in many parts of the world.");
        }

        private void BtnGalapagos_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The top shell of a tortoise is called the carapace; the shell that covers a tortoise's belly is called the plastron. The populations of Galápagos tortoises that live on the hotter and drier islands of the Galápagos have developed shells that are saddle-shaped with a high notch above the neck. This allows them to stretch their necks higher to reach vegetation that grows above the ground. Tortoises lay eggs. Females lay their eggs in nest holes, which they cover and leave. Babies hatch in four to eight months. They are on their own from the beginning.");
        }


        private void BtnPlay_OnClick(object sender, RoutedEventArgs e)
        {
            Play();
        }

        private void Play()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.diamondbackrattlesnake;
            try
            {
                player.Load();
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
