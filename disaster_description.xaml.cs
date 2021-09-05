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
    /// Interaction logic for disaster_description.xaml
    /// </summary>
    public partial class disaster_description : UserControl
    {
        
        private Hyperlink[] sources;
        public disaster_description(string description, string[] source_uri)
        {
            InitializeComponent();
            sources = new Hyperlink[source_uri.Length];
            for (int i = 0; i < source_uri.Length; ++i)
            {
                var hyperlink = new Hyperlink();
                var link = source_uri[i];

                hyperlink.NavigateUri = new Uri(link);
                hyperlink.Inlines.Add(link);

                sources[i] = hyperlink;
            }

            description_box.Text = description;
            list_box.ItemsSource = sources;
        }
    }
}
