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
    /// Interaction logic for TestChoosing.xaml
    /// </summary>
    public partial class TestChoosing : Page
    {
        TestPage testPage;
        public TestChoosing()
        {
            InitializeComponent();
            testPage = new TestPage();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void NumberPlatesBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(testPage);
            
        }
    }
    
}
