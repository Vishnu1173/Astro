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

namespace Astro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name = nameTextBox.Text;
            String ageStr = ageTextBox.Text;
            String qualification = qualificationTextBox.Text;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(ageStr) || String.IsNullOrEmpty(qualification))
            {
                PredictionText.Text = "please fill in all details.";
                return;
            }

            if (!int.TryParse(ageStr, out int age) || age <= 0)
            {
                PredictionText.Text = "please enter the valid  positive age.";
                return;
            }

            string prediction = $"Hello {name},at the age of {age},your qualification as {qualification} indicates bright future.";
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btngenerateAstrologyPrediction_Click(object sender, RoutedEventArgs e)
        {

        }
    }
   


}
