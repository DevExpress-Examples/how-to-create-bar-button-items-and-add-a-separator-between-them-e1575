using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarItemLinkSeparatorEx {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        
        // Respond to clicking the bar items
        private void itemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("Item " + e.Item.Content + " has been clicked.");
        }
        
    }
}
