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
    public partial class pemex_tab : UserControl
    {
        private Dictionary<string, contact_form> contacts;
        public pemex_tab()
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
                "Oficialía de Partes, ubicada en Bahía del Espíritu Santo s/n, acera Sur-Oriente, Planta Baja, Colonia Verónica Anzures, (entre Bahía de San Hipólito y Bahía de Ballenas) Alcaldía de Miguel Hidalgo, Código Postal 11300, en la Ciudad de México."
            };
            var nums = new string[] {
                "Ciudad de México: (01) 55 1944 2500, Exts. 70423 y 70447",
                "Lada sin costo: 01 800 522 6363"
            };
            var emails = new string[] {

            };
            var tmp = new contact_form(addr, nums, emails);
            ret.Add("Quejas y denuncias", tmp);

            addr = new string[] { };
            nums = new string[] { };
            emails = new string[]
            {
                "laetica@pemex.com"
            };
            tmp = new contact_form(addr, nums, emails);
            ret.Add("Línea Ética", tmp);

            return ret;
        }

    

        private void contact_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contact_box.Children.Clear();
            contact_box.Children.Add(contacts[contact_list.SelectedItem.ToString()]);
        }
    }
}
