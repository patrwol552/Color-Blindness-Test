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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Main_Window.xaml
    /// </summary>
    public partial class Main_Window : Page
    {
        HelpPage helpPage;
        TestChoosing testChoosing;
        public Main_Window()
        {
            InitializeComponent();
            ShowsNavigationUI = false;
            helpPage = new HelpPage();
            testChoosing = new TestChoosing();
                       

        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(helpPage);
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(testChoosing);
        }
    }
}
