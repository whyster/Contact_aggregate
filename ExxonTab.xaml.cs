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

namespace accountability_contacts
{
    /// <summary>
    /// Interaction logic for ExxonTab.xaml
    /// </summary>
    public partial class ExxonTab : UserControl
    {
        private Dictionary<String, disaster_description> disaster_descriptions;
        private Dictionary<String, contact_form> exxon_contacts;
        public ExxonTab()
        {
            InitializeComponent();
            //disaster_descriptions = generate_descriptions();
            //disaster_tab.ItemsSource = disaster_descriptions.Keys;
            exxon_contacts = generate_contacts();
            contact_list.ItemsSource = exxon_contacts.Keys;

        }

        private Dictionary<string, contact_form> generate_contacts()
        {
            var ret = new Dictionary<string, contact_form>();


            var addr = new string[] {
                "Corporate Headquarters \n" +
                "5959 Las Colinas Boulevard \n" +
                "Irving, Texas 75039-2298",


                "Downstream Operations\n"+
                "22777 Springwoods Village Parkway\n" +
                "Spring, TX 77389-1425",

                "Exploration and Producing Operations\n"+
                "22777 Springwoods Village Parkway\n"+
                "Spring, TX 77389-1425",

                "ExxonMobil Chemical\n"+
                "22777 Springwoods Village Parkway\n" +
                "Spring, TX 77389-1425"
            };
            var nums = new string[] {
                "Corporate Headquarters\n +1 (972) 940-6000"
            };
            var emails = new string[] {
            };
            var tmp = new contact_form(addr, nums, emails);
            ret.Add("Business Headquarters", tmp);

            addr = new string[] {
            
            };
            nums = new string[] {
                "Canada\n" +
                "Eastern Canada: +1 709 273 1400\n" +
                "Western/Northern/Central Canada: +1 587 476 7010",

                "Latin America\n" +
                "Brazil: +55 21 3206 5060\n" +
                "Argentina: +54 11 3985 3323 or +54 11 3985 3324\n" +
                "Mexico: +52 55 5125 0700\n" +
                "Guyana: +1 592 620 0616",

                "Europe\n" +
                "All inquiries: +44 1372 22 2261 or +44 1372 22 2000",

                "Asia Pacific\n" +
                "Australia: +61 39261 0022\n" +
                "Indonesia: +62 811 871 3486 or 62 811 103 6999\n" +
                "Malaysia: +60 3 4815 2484 or +60 3 4815-2289\n" +
                "Singapore: +65 6885 8275",

                "Africa\n" +
                "Angola: +244 938 761 994\n" +
                "Chad/Cameroon: +44 13729 41578\n" +
                "Equatorial Guinea: +1 240 222 244 534\n" +
                "Nigeria: +234 1 280 1100 ext. 22002",

                "Russia/Caspian\n" +
                "Azerbaijan: +994 12 982 460 \n" +
                "Kazakhstan: +7 7172 694 101\n" +
                "Moscow: +7 495 139 1444\n" +
                "Sakhalin: +7 4242 677363 or +7 4242 677360",

                "Middle East\n" +
                "Qatar: +974 4045 9187\n" +
                "Saudi Arabia: +966 1 273 8425"
            };
            emails = new string[] {
            };
            tmp = new contact_form(addr, nums, emails);
            ret.Add("Media Contact", tmp);


            return ret;
        }

        private Dictionary<string, disaster_description> generate_descriptions()
        {
            var ret = new Dictionary<string, disaster_description>();

            var tmp = new disaster_description("ExxonMobil conducting decades of research starting in 1970 discovers that to prevent irreversible damage major reductions in fossil fuel usage would be required." +
                "In 1997, when climate change started picking up support, ExxonMobil's CEO expressed doubt in climate change fears." +
                "Over the course of 10 years, ExxonMobil would face mounting pressure from the scientific community for their inaction in preventing climate change.", new string[] { "https://www.pulitzer.org/finalists/insideclimate-news", "https://insideclimatenews.org/project/exxon-the-road-not-taken/" });
            ret.Add("Exxon's inaction", tmp);


            return ret;
        }

        /*private void disaster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            description_grid.Children.Clear();
            description_grid.Children.Add(disaster_descriptions[disaster_tab.SelectedItem.ToString()]);

        } */
         
        private void contact_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contact_box.Children.Clear();
            contact_box.Children.Add(exxon_contacts[contact_list.SelectedItem.ToString()]);
        }
    }
}
