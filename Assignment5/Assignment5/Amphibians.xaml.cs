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
    /// Interaction logic for Amphibians.xaml
    /// </summary>
    public partial class Amphibians : Window
    {
        private MainWindow mainWindow;

        public Amphibians(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }

        private void BtnClownTreeFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The colors of these frogs can be orange, green, yellow, brown, black, blue,  and even purple!  The underside of is white, yellow, orange, and/or red. There are eighty-two species in this genus. The animals in this genus are sometimes also called stub-foot toads. Due to how rare these frogs are, there is not a lot of information.");
        }

        private void BtnMonkeyFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Monkey frog lives in the Amazon Basin in South America, and can be found in Venezuela, Brazil, Colombia, Peru, Bolivia, and the Guianas. As you can guess by its name, the Monkey frog likes to climb, and is part of the tree frog family. You can find it in sitting in trees well above the ground in warm tropical rainforest. Monkey frogs are nocturnal. They are carnivorous, and eat insects and any other small creatures they can catch!");
        }

        private void BtnMilkFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Amazon milk frog, also known as 'mission golden-eyed tree frog' or 'blue milk frog' belongs to the family known as 'tree frogs and their allies'. It can be found in northern parts of South America. Amazon milk frog inhabits moist, tropical rainforests. It lives on the trees near the slow-flowing waters. Habitat loss (due to intense deforestation) and fungal diseases represent major threats for the survival of Amazon milk frogs in the wild. Despite these factors, Amazon milk frogs are still numerous and widespread in the Amazon jungle.");
        }

        private void BtnPoisonDartFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("These frogs are considered one of Earth's most toxic, or poisonous, species. For example, the golden poison dart frog has enough poison to kill 20,000 mice. With a range of bright colors—yellows, oranges, reds, greens, blues—they aren't just big show-offs either. Those colorful designs tell potential predators, 'I'm toxic. Don't eat me.' Scientists think that poison dart frogs get their toxicity from some of the insects they eat. How do poison dart frogs capture their prey? Slurp! With a long, sticky tongue that darts out and zaps the unsuspecting bug! The frogs eat many kinds of small insects, including fruit flies, ants, termites, young crickets, and tiny beetles, which are the ones scientists think may be responsible for the frogs' toxicity. Poison dart frogs live in the rain forests of Central and South America.");
        }

        private void BtnHornedFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The first thing that stands out about the Surinam horned frog is its size. These rotund amphibians can grow to 8 inches in length and would cover a good-size tea saucer. They are found in freshwater marshes and pools throughout the Amazon Basin, from Colombia to Brazil.");
        }

        private void BtnEmeraldGlassFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The emerald glass frog (Espadarana prosoblepon), native to Central and South American forests, is an interesting species that literally has nothing to hide. Its belly is clear, allowing its bones and intestines to be visible to observers. Interestingly enough, this frog has green bones because of biliverdin, a type of pigment! The emerald glass frog resides in low vegetation and is frequently found near rivers and streams.");
        }

        private void BtnSmokeyJungleFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Smoky Jungle Frog is definitely one of our most impressive frogs. Its enormous size and girth will consistently draw gasps of shock and, at times, horror from our guests on The Night Tour.Smoky Jungle Frog - Leptodactylus savagei They are Costa Rica's largest frog species and second largest amphibian. Only the Giant Marine Toad (Bufo marinus) is larger. Adult Smoky Jungle Frogs may measure between 106 and 185 millimeters! But it is not just their size that makes them intimidating.");
        }

        private void BtnSplendedLeapFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Splendid Leaf Frogs is the holy grail of tree frogs with big silver eyes and the amazing yellow/orange side stripes and feet.  They are quite impressive in person and one can easily see why they were given their common name! It is a nocturnal, arboreal frog inhabiting primary humid lowland forest.");
        }

        private void BtnAmazonianPoisonFrog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Amazon dart frog is one of the most widespread of all dart frog species.These poisonous animals are found across the Amazon.Their colors serve as a warning");
        }
    }
}
