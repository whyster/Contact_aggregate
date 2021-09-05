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
    /// Interaction logic for pemex_tab.xaml
    /// </summary>
    public partial class BP_Tab : UserControl
    {
        private Dictionary<string, contact_form> contacts;
        public BP_Tab()
        {
            InitializeComponent();
            //disaster_descriptions = generate_descriptions();
            //disaster_tab.ItemsSource = disaster_descriptions.Keys;
            contacts = generate_contacts();
            contact_list.ItemsSource = contacts.Keys;

        }

        private Dictionary<string, contact_form> generate_contacts()
        {
            var ret = new Dictionary<string, contact_form>();


            var addr = new string[] {
                "China\n"+
                "北京市朝阳区东三环中路1号环球金融中心西塔20层",
                "Mexico\n"+
                "Av. Santa Fe #505 Piso 18\n" +
                "Colonia Cruz Manca, Cuajimalpa 05349CDMX,"

               
            };
            var nums = new string[] {
                "China\n" +
                "+86 (10) 6589 3888",

                "United States\n"+
                "+1 800 333 3991",
                "Mexico\n"+
                "01800-6680209"
            };

            var emails = new string[] {
                "United States\n" +
                "bpconsumer@bp.com",
                "Mexico\n"+
                "contactanos@bp.com"

            };
            var tmp = new contact_form(addr, nums, emails);
            ret.Add("Comments and Complaints", tmp);
            return ret;
        }



        private void contact_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contact_box.Children.Clear();
            contact_box.Children.Add(contacts[contact_list.SelectedItem.ToString()]);
        }
    }
}
