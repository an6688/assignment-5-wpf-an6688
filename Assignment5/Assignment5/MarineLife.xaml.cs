using System;
using System.Collections.Generic;
using System.IO;
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

        private void BtnTigerShark_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tiger sharks are named for the dark, vertical stripes found mainly on juveniles. As these sharks mature, the lines begin to fade and almost disappear. These large, blunt-nosed predators have a duly earned reputation as man-eaters. They are second only to great whites in attacking people. But because they have a near completely undiscerning palate, they are not likely to swim away after biting a human, as great whites frequently do.");
        }

        private void BtnOceanSunfish_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sunfish, or mola, develop their truncated, bullet-like shape because the back fin which they are born with simply never grows. Instead, it folds into itself as the enormous creature matures, creating a rounded rudder called a clavus. Mola in Latin means 'millstone' and describes the ocean sunfish’s somewhat circular shape. They are a silvery color and have a rough skin texture.");
        }

        private void BtnLionfish_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The lionfish, a longstanding showstopper in home aquariums, is a flourishing invasive species in U.S. Southeast and Caribbean coastal waters. This invasive species has the potential to harm reef ecosystems because it is a top predator that competes for food and space with overfished native stocks such as snapper and grouper. Scientists fear that lionfish will also kill off helpful species such as algae-eating parrotfish, allowing seaweed to overtake the reefs. In the U.S., the lionfish population is continuing to grow and increase its range. This is largely because lionfish have no known predators and reproduce all year long; a mature female releases roughly two million eggs a year.");
        }

        private void BtnDolphin_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The short-beaked common dolphin is the most numerous dolphin species in the offshore waters of the Atlantic, Pacific, and Indian Oceans. The long-beaked common dolphin has only recently been recognized as a distinct species, and is only commonly found within about 50 miles of the coast from Baja California to central California in the eastern North Pacific. In all oceans, common dolphins occur in tropical and warm temperate waters, often in very large groups of many hundreds, if not thousands, of animals. Common dolphins are fast and energetic swimmers. They are frequently seen bowriding in front of boats and performing jumps and leaps above the water surface.Common dolphins have sleek bodies that average 2.3 m (7.5 ft) in length.");
        }

        private void BtnReefButterflyfish_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butterflyfish, with their amazing array of colors and patterns, are among the most common sights on reefs throughout the world. Although some species are dull-colored, most wear intricate patterns with striking backgrounds of blue, red, orange, or yellow. Many have dark bands across their eyes and round, eye-like dots on their flanks to confuse predators as to which end to strike and in which direction they're likely to flee.");
        }

        private void BtnGreenSeaTurtle_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("They are easily distinguished from other sea turtles because they have a single pair of prefrontal scales (scales in front of its eyes), rather than two pairs as found on other sea turtles. Head is small and blunt with a serrated jaw. Carapace is bony without ridges and has large, non-overlapping, scutes (scales) present with only 4 lateral scutes. Body is nearly oval and is more depressed (flattened) compared to Pacific green turtles. All flippers have 1 visible claw. The carapace color varies from pale to very dark green and plain to very brilliant yellow, brown and green tones with radiating stripes.");
        }

        private void BtnMahiMahi_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mahi-mahi have compressed bodies and a single long-based dorsal fin extending from the head almost to the tail.[6] Mature males have prominent foreheads protruding well above the body proper. Females have a rounded head. Their caudal fins and anal fins are sharply concave. They are distinguished by dazzling colors - golden on the sides, and bright blues and greens on the sides and back. The pectoral fins of the mahi-mahi are iridescent blue. The flank is broad and golden. Out of the water, the fish often change color (giving rise to their Spanish name, dorado, 'golden'), going through several hues before finally fading to a muted yellow-grey upon death.");
        }

        private void BtnHumbackWhale_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Humpback whales are found in every ocean in the world. Their Latin name, Megaptera novaeangliae, means 'big wing of New England.' It refers to their giant pectoral fins, which can grow up to 16 feet long, and their appearance off the coast of New England, where European whalers first encountered them. They have dark backs, light bellies, pleats on their throats, and a small hump in front of their dorsal fin, leading to the common name of 'humback.' Humpback whales are known for their magical songs, which travel for great distances through the world's oceans. These sequences of moans, howls, cries, and other noises are quite complex and often continue for hours on end. Scientists are studying these sounds to decipher their meaning. It is most likely that humpbacks sing to communicate with others and to attract potential mates. Humpback calves are known to 'whisper' to their mothers.");
        }

        private void BtnLanternShark_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Lantern Shark is also referred to as the velvet belly lantern or velvet belly shark. Growing only about 18 inches in length, it is one of the smallest shark species in the world and it lives in the deep waters between depths of 660 and 8000 feet. Except for its belly, a majority of its body is brown in colour. It is a rather stout shark species, with a long flat snout and a thin tail. Its name comes from the black 'velvet' belly which is bioluminescent. There are light-emitting photophores in its belly that produces the light. This light provides the shark with an unusual camouflage from predators.");
        }

        private void BtnGiantSquid_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The giant squid is massive and when full grown can be at least 33 feet (10 meters) long. These mysterious eight-armed creatures are rarely seen by humans. Most of what we know about them comes from finding them washed up on beaches. The largest of these hard-to-find giants ever found measured 59 feet (18 meters) in length and weighed nearly a ton (900 kilograms). Giant squid, along with their cousin, the colossal squid, have beach-ball size eyes! Their eyes are the largest eyes in the animal kingdom and are about 10 inches (25 centimeters) in diameter. Their big eyes help them to spy objects in dark depths where most other animals would see nothing. Like other squid species, they have eight arms and two longer whiplike tentacles that help them bring food to their beaklike mouths. ");
        }

        private void BtnAnglerFish_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("An anglerfish is a type of fish that lives deep in the ocean. It finds food by angling prey in with a light that comes off the front of its head, which acts like a fishing lure. The fishing lure on the anglerfish is called the illicium. The anglerfish lives in the deepest part of the ocean where there is no light. Having no light makes it hard for fish to find food. The anglerfish has become good at finding food by lighting up the tip of the illicium, which brings in smaller fish for them to eat. Take a look at the picture below to see the long sharp teeth and glowing illicium of the angler fish.");
        }

        private void BtnBlackSwallower_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The black swallower is a small fish, with a maximum known length of 25 cm (9.8 in)! The body is elongated and compressed, without scales, and is a uniform brownish-black in color. Its head is long, with a blunt snout, moderately sized eyes, and a large mouth. The lower jaw protrudes past the upper; both jaws are lined with a single row of sharp, depressible teeth, which interlock when the mouth is closed. The first three teeth in each jaw are enlarged into canines.");
        }

        private void BtnGiantTubeWorms_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The giant tube worm was totally unknown to science until researchers exploring the deep Pacific Ocean floor discovered strange, hydrothermal vents. Powered by volcanic heat, these vents recirculate water that seeps down through cracks or faults in the rock. When the water emerges from the vent, it is rich in chemicals and minerals. This toxic soup of chemicals would be lethal to most animals, so scientists were shocked to find entire ecosystems of animals living around these vents. In spite of the near boiling temperature of the water, these animals were thriving in the complete absence of light. The organisms that live near these vents are unique because, unlike all other living things on earth, they do not depend on sunlight for their source of energy! Instead, they feed on tiny bacteria that get their energy directly from the chemicals in the water through a process known as chemosynthesis.");
        }

        private void BtnVampireSquid_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The vampire squid can grow to about 30 cm (1 foot) in total length. It is no threat to humans. Its 15 cm (6 inch) gelatinous body varies in color between velvety jet-black and pale reddish, depending on location and lighting conditions. A webbing of skin connects its eight arms, each lined with rows of fleshy spines or cirri. The inside of this 'cloak' is black. Only the distal half (farthest from the body) of the arms have suckers. Its limpid, globular eyes—which appear red or blue, also depending on lighting—are proportionately the largest in the animal kingdom at 2.5 cm (1 inch) in diameter.");
        }

        private void BtnHatchetFish_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The deep sea hatchetfish gets its name from the distinct hatchet-like shape of its body. It is a member of the Sternoptychidae family of deep sea fishes. There are about 45 individual species of hatchetfish that vary in size from one to six inches. They are most well known for their extremely thin bodies which really do resemble the blade of a hatchet. They should not be confused with the freshwater hatchetfish commonly seen in home aquariums.");
        }

        private void BtnCombJelly_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Comb jellies are beautiful, oval-shaped animals with eight rows of tiny comblike plates that they beat to move themselves through the water. As they swim, the comb rows diffract light to produce a shimmering, rainbow effect. Voracious predators on other jellies, some can expand their stomachs to hold prey nearly half their own size. Jellies are simple creatures with few specialized organs. Most jellies can detect chemical traces in the water that allow them to locate food, and many are equipped with a gravity-sensitive structure, called a statocyst, that gives them a sense of up and down in the water.");
        }

        private void BtnSpermWhale_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sperm whales are part of the Odontoceti (toothed whales). The Sperm whale is the largest toothed mammal in the world! Like most odontocetes, the males are larger than the females. They can weigh up to 110,000 pounds and measure in at 20 meters. Females are much smaller, weighing 36,000 pounds and measuring in at 13 meters. They are dark-grey to black in colour. They have a large, square-shaped head with a small lower jaw (relative to the top part of the head). With no dorsal fin and only one blowhole, they, surprisingly, have similarities to the Beluga whale and Narwhal. The Sperm whale achieved its general name because of its large head. Within this head is a spermaceti organ which is filled with spermaceti oil. This oil solidifies as the water gets colder. Because of this, the sperm whale is able to dive deeper than any other whale (up to 1,200 meters!). Its head basically weighs it down and gives it momentum to swim against the pressures of the deep ocean. Also, the Sperm whale can hold its breath for 90 minutes!");
        }

        private void BtnPlay_OnClick(object sender, RoutedEventArgs e)
        {
            Play();
        }

        private void Play()
        {
            string soundFile = @"sounds/hmpback1.wav";
            var sound = new System.Media.SoundPlayer(soundFile);
            sound.Play();

        }
    }
}
