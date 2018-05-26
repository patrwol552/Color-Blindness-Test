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
using System.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        Answers answers;
        ResultsPage resultsPage;
        
        List<string> plateString = new List<string>();
        List<string> platesPng = new List<string>();

        public TestPage()
        {
            InitializeComponent();
            answers = new Answers();
            resultsPage = new ResultsPage();

            opt1btn.IsEnabled = false;
            opt2btn.IsEnabled = false;
            opt3btn.IsEnabled = false;

            answers.CreateOptions(plateString, platesPng);

        }

        int j = 1;
        int i = 3;

        private void NextPlateBtn_Click(object sender, RoutedEventArgs e)
        {
            
                    if (j == platesPng.Count-1)
                    {
                        this.NavigationService.Navigate(resultsPage);

                    }

             
             opt1btn.IsChecked = false;
             opt2btn.IsChecked = false;
             opt3btn.IsChecked = false;
             
             opt1btn.Content = plateString[i];
             opt2btn.Content = plateString[i + 1];
             opt3btn.Content = plateString[i + 2];
             
              ProgressLabel.Content = (j+1) + "/" + platesPng.Count.ToString();
              IshiharaPlate.Source = new BitmapImage(new Uri(@"C:\studia\pum projekt\WpfApplication1\WpfApplication1\Plates\" + platesPng[j].ToString(), UriKind.RelativeOrAbsolute));

                if (opt1btn.IsChecked == true || opt2btn.IsChecked == true || opt3btn.IsChecked == true)
                {
                    NextPlateBtn.IsEnabled = true;
                  
                   
                }

            i=i+3;
            j++;

        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            StartBtn.Visibility = Visibility.Hidden;
            opt1btn.IsEnabled = true;
            opt2btn.IsEnabled = true;
            opt3btn.IsEnabled = true;
            IshiharaPlate.Source= new BitmapImage(new Uri(@"C:\studia\pum projekt\WpfApplication1\WpfApplication1\Plates\" + platesPng[0].ToString(), UriKind.RelativeOrAbsolute));
            opt1btn.Content = plateString[0];
            opt2btn.Content = plateString[1];
            opt3btn.Content = plateString[2];

            ProgressLabel.Visibility = Visibility.Visible;
            
            TestLabel.Visibility = Visibility.Visible;
            NextPlateBtn.Visibility = Visibility.Visible;
            opt1btn.Visibility = Visibility.Visible;
            opt2btn.Visibility = Visibility.Visible;
            opt3btn.Visibility = Visibility.Visible;
        }
    }
}


