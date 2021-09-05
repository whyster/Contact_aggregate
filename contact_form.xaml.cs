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
    /// Interaction logic for contact_form.xaml
    /// </summary>
    public partial class contact_form : UserControl
    {
        public contact_form(string[] Addr, string[] Nums, string[] Ems)
        {
            InitializeComponent();
            Addresses.ItemsSource = Addr;
            Numbers.ItemsSource = Nums;
            Emails.ItemsSource = Ems;
        }
    }
}
