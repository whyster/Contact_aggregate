using System.Collections.Generic;
using System.Windows.Controls;

namespace accountability_contacts {
    public partial class Sinopec_tab : UserControl {
        private Dictionary<string, contact_form> contacts;
        public Sinopec_tab() {
            InitializeComponent();
                        contacts = generate_contacts();
            contact_list.ItemsSource = contacts.Keys;
        }
        
        private Dictionary<string, contact_form> generate_contacts()
        {
            var ret = new Dictionary<string, contact_form>();


            var addr = new string[] {
                "中国北京市朝阳区朝阳门北大街22号\n邮政编码:100728"
            };
            var nums = new string[] {
                "8610-59960114"
            };
            var emails = new string[] {

            };
            var tmp = new contact_form(addr, nums, emails);
            ret.Add("Sinopec", tmp);


            return ret;
        }

    

        private void contact_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contact_box.Children.Clear();
            contact_box.Children.Add(contacts[contact_list.SelectedItem.ToString()]);
        }
    }
}