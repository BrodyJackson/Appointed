using Appointed.Views.Controls;
using Appointed.Views.Dialogs;
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

namespace Appointed.Views.Sidebar.Widgets.PatientInfoWidgets
{
    /// <summary>
    /// Interaction logic for PatientBasicInfoView.xaml
    /// </summary>
    public partial class PatientBasicInfoView : UserControl
    {
        public PatientBasicInfoView()
        {
            InitializeComponent();

            PatientBirthdayDatePicker.SelectedDateChanged += PBDayDatePickerDateSelected;
        }

        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

            if (t.Name == "PatientName")
            {
                NameInput.Visibility = Visibility.Visible;
                NameInput.TextField.Text = PatientName.Text;
                NameInput.TextField.Focus();
            }
            else if (t.Name == "PatientID")
            {
                IDInput.Visibility = Visibility.Visible;
                IDInput.TextField.Text = PatientID.Text.Substring(PatientID.Text.IndexOf(':') + 2);
                IDInput.TextField.Focus();
            }
            else
            {
                SexInput.Visibility = Visibility.Visible;
                SexInput.TextField.Text = PatientSex.Text.Substring(PatientSex.Text.IndexOf(':') + 2);
                SexInput.TextField.Focus();
            }
        }


        private void OnClickPatientBirthday(object sender, MouseButtonEventArgs e)
        {
            PatientBirthdayDatePicker.Visibility = Visibility.Visible;
            PatientBirthdayDatePicker.InputText.TextField.Text = PatientBirthday.Text.Substring(PatientBirthday.Text.IndexOf(':') + 2);
        }


        private void NameInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = NameInput.TextField.Text;

            if (field != "Name" && field != "")
                PatientName.Text = field;

            NameInput.Visibility = Visibility.Hidden;
        }

        private void IDInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = IDInput.TextField.Text;

            if (field != "12345-678" && field != "" && field.Length == 9)
                PatientID.Text = "ID: " + field;

            IDInput.Visibility = Visibility.Hidden;
        }

        private void SexInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = SexInput.TextField.Text;

            if (field != "Sex" && field != "")
                PatientSex.Text = "Sex: " + field;

            SexInput.Visibility = Visibility.Hidden;
        }

        private void PBDayDatePickerDateSelected(object sender, RoutedEventArgs e)
        {
            string dateStr;
            DateTime dt = DateTime.Parse(PatientBirthdayDatePicker.InputText.TextField.Text);

            dateStr = dt.Year.ToString() + '-' + dt.Month.ToString() + '-' + dt.Day.ToString();
            PatientBirthday.Text = "Birthdate: " + dateStr;
            PatientBirthdayDatePicker.Visibility = Visibility.Hidden;                        
        }

    
        private void PBDayDatePickerLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            DateTime dt;

            if (!DateTime.TryParse(PatientBirthdayDatePicker.InputText.TextField.Text, out dt))
                return;

            string dateStr;
            dt = DateTime.Parse(PatientBirthdayDatePicker.InputText.TextField.Text);

            dateStr = dt.Year.ToString() + '-' + dt.Month.ToString() + '-' + dt.Day.ToString();
            PatientBirthday.Text = "Birthdate: " + dateStr;
            PatientBirthdayDatePicker.Visibility = Visibility.Hidden;
        }
    }
}
