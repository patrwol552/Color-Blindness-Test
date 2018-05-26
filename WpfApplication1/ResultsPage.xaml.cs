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
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        
        EmailPage emailPage;
        DetailsPage detailsPage;
        public ResultsPage()
        {
            InitializeComponent();
            
            emailPage = new EmailPage();
            detailsPage = new DetailsPage();
        }

        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
               
            }
        }

        private void GetResultsBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(emailPage);
        }

        private void DetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(detailsPage);
        }
    }
}
