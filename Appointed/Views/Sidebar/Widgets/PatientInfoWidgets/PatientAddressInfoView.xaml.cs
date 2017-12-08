using Appointed.Classes;
using Appointed.Views.Controls;
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
        public Patient patient;

        public string City { get; private set; }
        public Patient.PROVINCE Province { get; private set; }

        public bool HasChanges { get; private set; }

        public PatientAddressInfoView()
        {
            InitializeComponent();
            Loaded += PatientAddressInfoView_Loaded;

            InputCity.LostFocus += InputCity_LostFocus;
            InputProv.DropDownClosed += InputProv_DropDownClosed;

            HasChanges = false;
        }

        private void InputProv_DropDownClosed(object sender, EventArgs e)
        {
            InputCity.TextField.Focus();
        }

        private void InputCity_LostFocus(object sender, RoutedEventArgs e)
        {
            var x = FocusManager.GetFocusedElement(App.Current.MainWindow) as ComboBox;
            if (x != null && x.Name == "InputProv")
            {
                return;
            }

            DoneRegionInput();
        }

        private void DoneRegionInput()
        {
            if(InputCity.TextField.Text != InputCity.Hint)
            {
                if(InputCity.TextField.Text != City)
                {
                    PatientRegion.Foreground = Brushes.Blue;
                    City = InputCity.TextField.Text;
                    HasChanges = true;
                }

                if((Patient.PROVINCE)Enum.Parse(typeof(Patient.PROVINCE), InputProv.Text) != Province)
                {
                    PatientRegion.Foreground = Brushes.Blue;
                    Province = (Patient.PROVINCE) Enum.Parse(typeof(Patient.PROVINCE), InputProv.Text);
                    HasChanges = true;
                }

                PatientRegion.Text = City + ", " + Province;
            }

            InputRegion.Visibility = Visibility.Hidden;
            PatientRegion.Visibility = Visibility.Visible;
            PatientRegion.IsEnabled = true;
        }

        private void PatientAddressInfoView_Loaded(object sender, RoutedEventArgs e)
        {
            PatientStreetAddress.Text = patient.Street;
            PatientRegion.Text = patient.City + ", " + patient.Province;
            City = patient.City;
            Province = patient.Province;
            PatientPostal.Text = patient.PostalCode;
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
                InputRegion.Visibility = Visibility.Visible;
                InputCity.TextField.Text = City.ToString();
                InputProv.SelectedIndex = (int)Province;
                PatientRegion.IsEnabled = false;
                PatientRegion.Visibility = Visibility.Hidden;
                InputCity.TextField.Focus();
            }
            else if(t.Name == "PatientPostal")
            {
                PatientPostalInput.Visibility = Visibility.Visible;
                PatientPostalInput.TextField.Text = PatientPostal.Text;
                PatientPostalInput.TextField.Focus();
            }
        }

        private void PatientPostalInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientPostalInput.TextField.Text;

            field = field.Insert(3, "-");
            field = field.Remove(4, 1);
            if(field != PatientPostalInput.Hint && field != patient.PostalCode && field.Length == 7)
            {
                PatientPostal.Text = field;
                PatientPostal.Foreground = Brushes.Blue;
                HasChanges = true;
            }

            PatientPostalInput.Visibility = Visibility.Hidden;
        }

        private void PatientStreetAddressInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientStreetAddressInput.TextField.Text;

            if(field != PatientStreetAddressInput.Hint && field != patient.Street)
            {
                PatientStreetAddress.Text = field;
                PatientStreetAddress.Foreground = Brushes.Blue;
                HasChanges = true;
            }

            PatientStreetAddressInput.Visibility = Visibility.Hidden;
        }
    }
}
