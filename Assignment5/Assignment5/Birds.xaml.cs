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
    /// Interaction logic for Birds.xaml
    /// </summary>
    public partial class Birds : Window
    {
        private MainWindow mainWindow;

        public Birds(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }

        private void btnGallicolumbaLuzonica_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The Luzon bleeding-heart (Gallicolumba luzonica) is one of a number of species of ground dove in the genus Gallicolumba that are called 'bleeding - hearts'. The Luzon Bleeding-heart is the species in which the 'blood' feature is most pronounced, with the reddish hue extending down the belly, furthering the illusion of blood having run down the bird's breast.");
        }

        private void BtnEngouleventOrdinaire_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Also known as The Common Nighthawk, this is a bird species that ranges from the extreme south of Canada to South America (with the exception of the southern hemisphere) and a bird species of the family Caprimulgidae. Like all Nighthawks, it is a twilight and nocturnal bird. It has a very complex cryptic plumage, mixing gray, beige and brown, which gives it an effective camouflage during the day, when it remains on the ground or perched, motionless, along a branch.");
        }

        private void BtnPelecanus_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Pelicans are a genus of large water birds that make up the family Pelecanidae. They are characterised by a long beak and a large throat pouch used for catching prey and draining water from the scooped-up contents before swallowing. They have predominantly pale plumage, the exceptions being the brown and Peruvian pelicans. The bills, pouches, and bare facial skin of all species become brightly coloured before the breeding season. The eight living pelican species have a patchy global distribution, ranging latitudinally from the tropics to the temperate zone, though they are absent from interior South America and from polar regions and the open ocean.");
        }

        private void BtnCallipeplaCalifornica_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The California quail (Callipepla californica), also known as the California valley quail or valley quail, is a small ground-dwelling bird in the New World quail family. These birds have a curving crest or plume, made of six feathers, that droops forward: black in males and brown in females; the flanks are brown with white streaks. Males have a dark brown cap and a black face with a brown back, a grey-blue chest and a light brown belly. Females and immature birds are mainly grey-brown with a light-colored belly.");
        }

        private void BtnPlatycercusEximius_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The eastern rosella (Platycercus eximius) is a rosella native to southeast of the Australian continent and to Tasmania.The eastern rosella was named by George Shaw in 1792. It is sometimes considered a subspecies of the pale-headed rosella (P. adscitus). The term 'white-cheeked rosella' has been used for a species or superspecies combining the pale-headed and eastern forms. Hybrids of the two taxa have been recorded where their ranges meet in northeastern New South Wales and southeastern Queensland. However, a mitochondrial study published in 2017 found that the eastern rosella was the earlier offshoot of the lineage that split into the pale-headed and northern rosellas, and that nonsister taxa were hence able to hybridise.");
        }

        private void BtnTragopanFromHastings_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The deployed bib is turquoise blue with a purple center bar dotted with turquoise dots and carmine pink on each edge.The Western Tragopan (Tragopan melanocephalus) is a species of bird belonging to the family of Phasianidae. It is a monotypic species");
        }

        private void BtnHoccoRoux_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The great curassow (Crax rubra) is a large, pheasant-like bird from the Neotropical rainforests, its range extending from eastern Mexico, through Central America to western Colombia and northwestern Ecuador. Male birds are black with curly crests and yellow beaks; females come in three colour morphs, barred, rufous and black. These birds form small groups, foraging mainly on the ground for fruits and arthropods, and the occasional small vertebrate, but they roost and nest in trees. This species is monogamous, the male usually building the rather small nest of leaves in which two eggs are laid. This species is threatened by loss of habitat and hunting, and the International Union for Conservation of Nature has rated its conservation status as 'vulnerable'.");
        }

        private void BtnMouetteRieuse_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The black-headed gull (Chroicocephalus ridibundus) is a small gull that breeds in much of Europe and Asia, and also in coastal eastern Canada. Most of the population is migratory and winters further south, but some birds reside in the milder westernmost areas of Europe. Some black-headed gulls also spend the winter in northeastern North America, where it was formerly known as the common black-headed gull. As is the case with many gulls, it was previously placed in the genus Larus.");
        }

        private void BtnDiomedeidae_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Albatrosses, of the biological family Diomedeidae, are large seabirds related to the procellariids, storm petrels, and diving petrels in the order Procellariiformes (the tubenoses). They range widely in the Southern Ocean and the North Pacific. They are absent from the North Atlantic, although fossil remains show they once occurred there and occasional vagrants are found. Albatrosses are among the largest of flying birds, and species of the genus Diomedea (great albatrosses) have the longest wingspans of any extant birds, reaching up to 3.7 m (12 ft). The albatrosses are usually regarded as falling into four genera, but disagreement exists over the number of species.");
        }

        private void BtnChouetteEffraie_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The barn owl (Tyto alba) is the most widely distributed species of owl and one of the most widespread of all birds. It is also referred to as the common barn owl, to distinguish it from other species in its family, Tytonidae, which forms one of the two main lineages of living owls, the other being the typical owls (Strigidae). The barn owl is found almost everywhere in the world except polar and desert regions, in Asia north of the Himalayas, most of Indonesia, and some Pacific islands.");
        }
    }
}
