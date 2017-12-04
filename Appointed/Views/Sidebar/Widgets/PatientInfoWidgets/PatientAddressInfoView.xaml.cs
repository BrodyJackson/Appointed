using Appointed.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Appointed.Views.Sidebar.Widgets.PatientInfoWidgets
{
    /// <summary>
    /// Interaction logic for PatientAddressInfoView.xaml
    /// </summary>
    public partial class PatientAddressInfoView : UserControl
    {
        public PatientAddressInfoView()
        {
            InitializeComponent();
        }


        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

            if (t.Name == "PatientStreetAddress")
            {
                PatientStreetAddressInput.Visibility = Visibility.Visible;
                PatientStreetAddressInput.TextField.Text = PatientStreetAddress.Text;
                PatientStreetAddressInput.TextField.Focus();
            }
            else if (t.Name == "PatientRegion")
            {
                PatientRegionInput.Visibility = Visibility.Visible;
                PatientRegionInput.TextField.Text = PatientRegion.Text;
                PatientRegionInput.TextField.Focus();
            }
            else
            {
                PatientPostalInput.Visibility = Visibility.Visible;
                PatientPostalInput.TextField.Text = PatientPostal.Text;
                PatientPostalInput.TextField.Focus();
            }
        }

        private void PatientPostalInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientPostalInput.TextField.Text;

            if (field != "A1B 2C3" && field != "" && (field.Length == 7))
            {
                PatientPostal.Text = field;
                PatientPostalInput.Visibility = Visibility.Hidden;
                PatientPostalInput.MarkValid();
            }
            else
                PatientPostalInput.MarkInvalid();
        }

        private void PatientRegionInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientRegionInput.TextField.Text;

            if (field != "City, Province" && field != "")
                PatientRegion.Text = field;

            PatientRegionInput.Visibility = Visibility.Hidden;
        }

        private void PatientStreetAddressInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientStreetAddressInput.TextField.Text;

            if (field != "Building # - Street Address" && field != "")
                PatientStreetAddress.Text = field;

            PatientStreetAddressInput.Visibility = Visibility.Hidden;
        }
    }
}
