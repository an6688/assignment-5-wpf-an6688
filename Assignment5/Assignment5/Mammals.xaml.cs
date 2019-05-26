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
    /// Interaction logic for Mammals.xaml
    /// </summary>
    public partial class Mammals : Window
    {
        private MainWindow mainWindow;

        public Mammals(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }

        private void BtnPerissodactyla_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Odd-toed ungulates, mammals which constitute the taxonomic order Perissodactyla (from the Ancient Greek περισσός perissós, 'uneven'; and δάκτυλος dáktylos, 'finger, toe'), are hoofed animals—ungulates—which bear most of their weight on one (an odd number) of the five toes: the third toe. The non-weight-bearing toes are either present, absent, vestigial, or positioned posteriorly. By contrast, the even-toed ungulates bear most of their weight equally on two (an even number) of the five toes: their third and fourth toes. Another difference between the two is that odd-toed ungulates digest plant cellulose in their intestines rather than in one or more stomach chambers as the even-toed ungulates do. The order includes about 17 species divided into three families: Equidae (horses, asses, and zebras), Rhinocerotidae (rhinoceroses), and Tapiridae (tapirs). Despite their very different appearances, they were recognized as related families in the 19th century by the zoologist Richard Owen, who also coined the order name.");
        }

        private void BtnPangolin_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Pangolins or scaly anteaters are mammals of the order Pholidota. The one extant family, Manidae, has three genera: Manis, which comprises four species living in Asia; Phataginus, which comprises two species living in Africa; and Smutsia, which comprises two species also living in Africa.[3] These species range in size from 30 to 100 cm (12 to 39 in). A number of extinct pangolin species are also known. Pangolins have large, protective keratin scales covering their skin; they are the only known mammals with this feature. They live in hollow trees or burrows, depending on the species. Pangolins are nocturnal, and their diet consists of mainly ants and termites, which they capture using their long tongues. They tend to be solitary animals, meeting only to mate and produce a litter of one to three offspring, which are raised for about two years.");
        }

        private void BtnSirenia_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"The Sirenia, commonly referred to as sea cows or sirenians, are an order of fully aquatic, herbivorous mammals that inhabit swamps, rivers, estuaries, marine wetlands, and coastal marine waters. The Sirenia currently comprise the families Dugongidae (the dugong and historically, Steller's sea cow) and Trichechidae (manatees) with a total of four species. The Protosirenidae (Eocene sirenians) and Prorastomidae (terrestrial sirenians) families are extinct. Sirenians are classified in the clade Paenungulata, alongside the elephants and the hyraxes, and evolved in the Eocene 50 million years ago. The Dugongidae diverged from the Trichechidae in the late Eocene or early Oligocene.");
        }

        private void BtnInsectivora_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The name insectivora (insect eater) has reference to the food habits of the group as a whole. Although moles and shrews are not all strictly insectivorous, insects and other small animal life constitute the chief dietary items of most members of the group. Some kinds, the otter shrews of Africa and the star-nosed mole of America, for example, feed also upon fish. The Townsend mole of the Pacific Northwest often is a nuisance to bulb growers because of its fondness for the bulbs of many kinds of plants.");
        }

        private void BtnPrimates_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A primate is any member of the biological order Primates, the group that contains all the species commonly related to the lemurs, monkeys, and apes, with the latter category including humans.");
        }

        private void BtnMarsupialia_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Marsupials are a group of mammals that are known for carrying their young in a pouch. Kangaroos, koalas, and opossums are well-known marsupials. Marsupials live in forests, lakes and streams, grasslands, and even underground.");
        }

        private void BtnMonotremata_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Monotremes are the only mammals that lay eggs, but they also feed their babies with milk.");
        }

        private void BtnLagomorpha_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lagomorpha is a mammal order. It includes pikas, rabbits and hares. Although the lagomorphs look like rodents, they are actually not because they have four incisors on the upper jaw, not two like in rodents, and they eat plants, not meat too, like rodents. They were classified under rodents until the 20th century. They are divided into two families, Leporidae, hares and rabbits, and Ochotonidae, the pikas.");
        }

        private void BtnProboscidea_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Proboscidea is an order containing only one family of living animals, Elephantidae, the elephants, with three living species (African forest elephant, African bush elephant, and Asian elephant). During the period of the last ice age there were more, now extinct species, including a number of species of the elephant-like mammoths and mastodons.");
        }

        private void BtnCarnivora_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The order Carnivora is a group of mammals. The group is divided into the 'cat - like' Feliformia and the 'dog - like' Caniformia. Animals of the order Carnivora are carnivores, a term which applies to all flesh-eaters. If one needs to refer to members of the order, then carnivorans is used. Many species of Carnivora are actually omnivores, and a few of them, like the Giant Panda, eat mostly plants.");
        }

        private void BtnCetacea_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The order Cetacea includes the marine mammals commonly known as whales, dolphins, and porpoises. Cetus is Latin and is used in biological names to mean whale. Its original meaning, large sea animal, was more general. It comes from Ancient Greek κῆτος (kētos), meaning whale or 'any huge fish or sea monster.' In Greek mythology, the monster Perseus defeated was called Ceto, which is depicted by the constellation of Cetus. Cetology is the branch of marine science associated with the study of cetaceans.");
        }

        private void BtnChiroptera_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bats are mammals in the order Chiroptera. They are the only mammals that can fly. Other mammals like flying squirrels, or flying possum, can glide but not fly. Bats are nocturnal – they are active during the night, dusk, or dawn. Most use echolocation to catch prey and to find their way about. As nighttime animals, bats avoid direct competition with birds, few of which are nocturnal.");
        }

        private void BtnRodentia_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rodents are a very successful group of mammals. They form the order Rodentia. They have four incisors. These keep growing, and must be kept worn down by gnawing (eroding teeth by grinding them on something hard). Most rodents are small. Examples of commonly known rodents are mice, rats, chipmunks, and squirrels. Some other small rodents sometimes kept as pets are Guinea pigs, hamsters, and gerbils. Examples of larger rodents are porcupines, beavers, and the largest living rodent, the capybara, which can grow to between 105 and 135 cm (40-55 in) in length, and weigh 35 to 65 kg (75-140 lbs)!");
        }

        private void BtnArtiodactyla_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The even-toed ungulates are mammals of the order Artiodactyla. Even-toed ungulates have an even number of toes: two to four. For example, camelids or animals of the Giraffidae family have two toes, but hippopotami have four toes. Excluding whales, the roughly 220 artiodactyl species include pigs, peccaries, hippopotamuses, cetaceans, camels, llamas, alpacas, mouse deer, deer, giraffes, antelopes, sheep, goats, and cattle, many of which are of great dietary, economic, and cultural importance to humans.");
        }

        private void BtnDermoptera_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Colugos are gliding mammals in the order Dermoptera. There are two living species, found in south-east Asia. They are also called 'flying lemurs', though they are not lemurs (all lemurs are in Madagascar). They can glide long distances, as they have a thin membrane stretched to the ends of the tail and each limb.");
        }

        private void BtnEdentata_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anteaters, armadillos, and sloths are a group of eutherian mammals known as the Xenarthra. They were once placed in the order Edentata and are still often referred to as edentates, a word that means 'toothless.' Although xenarthrans such as anteaters are indeed toothless, the giant armadillo has as many as 100 teeth, more than almost any other mammal. Members of the mammalian group Edentata not only include the 31 living species of armadillos, true anteaters, and tree sloths, but also contain eight families of extinct ground sloths and armadillo-like animals. Together, the living families and extinct families constitute the Xenarthra.");
        }

        private void BtnPinnipedia_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Seals are warm-blooded, air breathing mammals that live in or near the sea. There are many different species including fur seals, sea lions, and common seals. Learn more about seal habitats, what seals eat, how long they live and other interesting information with our fun seal facts.");
        }
    }
}
