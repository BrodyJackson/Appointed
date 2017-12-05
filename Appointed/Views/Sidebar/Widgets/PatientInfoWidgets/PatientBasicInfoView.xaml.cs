using Appointed.Classes;
using Appointed.ViewModels;
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
        public Patient patient;

        public string Fname { get; private set; }
        public string Mnames { get; private set; }
        public string Lname { get; private set; }

        public bool HasChanges { get; private set; }

        public PatientBasicInfoView()
        {
            InitializeComponent();

            Loaded += PatientBasicInfoView_Loaded;

            PatientBirthdayDatePicker.SelectedDateChanged += PBDayDatePickerDateSelected;
            PatientBirthdayDatePicker.InputText.TextField.LostFocus += PBDayDatePickerLostKeyboardFocus;
            SexInput.DropDownClosed += SexInput_DropDownClosed;
            SexInput.LostFocus += SexInput_LostFocus;

            HasChanges = false;
        }

        private void PatientBasicInfoView_Loaded(object sender, RoutedEventArgs e)
        {
            PatientName.Text = patient.LastName + ", " + patient.FirstName + ", " + patient.MiddleName[0] + ".";
            Fname = patient.FirstName;
            Mnames = patient.MiddleName;
            Lname = patient.LastName;

            PatientSex.Text = "Sex: " + patient.GetSexAsString();
            PatientID.Text = "ID: " + new HealthCareIDMask().FormatText(patient.HealthID.ToString());
            PatientBirthday.Text = "Birthdate: " + patient.BirthDate.ToString("yyyy-MM-dd");


        }

        private void SexInput_DropDownClosed(object sender, EventArgs e)
        {
            DoneSexInput();
        }

        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

            if (t.Name == "PatientName")
            {
                FNameInput.TextField.Text = Fname;
                MNameInput.TextField.Text = Mnames;
                LNameInput.TextField.Text = Lname;
                PatientName.Visibility = Visibility.Hidden;
                InputName.Visibility = Visibility.Visible;
                FNameInput.TextField.Focus();
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
                SexInput.SelectedIndex = PatientSex.Text.Substring(PatientSex.Text.IndexOf(':') + 2) == "Male" ? 0 : PatientSex.Text.Substring(PatientSex.Text.IndexOf(':') + 2) == "Female" ? 1 : 2;
                SexInput.Focus();
            }
        }

        private void OnClickPatientBirthday(object sender, MouseButtonEventArgs e)
        {
            PatientBirthdayDatePicker.Visibility = Visibility.Visible;
            PatientBirthdayDatePicker.InputText.TextField.Text = PatientBirthday.Text.Substring(PatientBirthday.Text.IndexOf(':') + 2);
            PatientBirthdayDatePicker.InputText.TextField.Focus();
        }

        private void IDInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = IDInput.TextField.Text;

            if (IsHealthcareIDValid() && int.Parse(field.Replace("-", "")) != patient.HealthID)
            {
                PatientID.Text = "ID: " + field;
                PatientID.Foreground = Brushes.Blue;
                HasChanges = true;
            }

            IDInput.Visibility = Visibility.Hidden;
        }

        private bool IsHealthcareIDValid()
        {
            int id;

            if ((IDInput.TextField.Text != IDInput.Hint && IDInput.TextField.Text.Length == 9) && Int32.TryParse(new String(IDInput.TextField.Text.Where(x => Char.IsDigit(x)).ToArray()), out id))
            {
                return !(App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.GetPatientDatabaseModel().GetPatientDictionary().ContainsKey(id);
            }
            else
            {
                return false;
            }
        }

        private void PBDayDatePickerDateSelected(object sender, RoutedEventArgs e)
        {
            string dateStr;
            DateTime dt = DateTime.Parse(PatientBirthdayDatePicker.InputText.TextField.Text);

            if (dt != patient.BirthDate)
            {
                PatientBirthday.Foreground = Brushes.Blue;
                dateStr = dt.ToString("yyyy-MM-dd");
                PatientBirthday.Text = "Birthdate: " + dateStr;
                HasChanges = true;
            }

            PatientBirthdayDatePicker.Visibility = Visibility.Hidden;
        }

        private void PBDayDatePickerLostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            DateTime dt;

            var x = FocusManager.GetFocusedElement(App.Current.MainWindow) as Button;
            if (x != null && x.Name == "ShowCalendarButton")
            {
                return;
            }

            if (!DateTime.TryParse(PatientBirthdayDatePicker.InputText.TextField.Text, out dt))
                return;

            string dateStr;
            dt = DateTime.Parse(PatientBirthdayDatePicker.InputText.TextField.Text);

            if (dt != patient.BirthDate)
            {
                PatientBirthday.Foreground = Brushes.Blue;
                dateStr = dt.ToString("yyyy-MM-dd");
                PatientBirthday.Text = "Birthdate: " + dateStr;
                HasChanges = true;
            }

            PatientBirthdayDatePicker.Visibility = Visibility.Hidden;
        }

        private void SexInput_LostFocus(object sender, RoutedEventArgs e)
        {
            var x = FocusManager.GetFocusedElement(App.Current.MainWindow) as ComboBoxItem;
            if(x != null )
            {
                var y = x.Parent as ComboBox;

                if(y != null && y.Name == "SexInput")
                    return;
            }
            else
            {
                DoneSexInput();
            }
        }

        private void DoneSexInput()
        {
            if (patient.GetSexAsString() != SexInput.Text)
            {
                PatientSex.Foreground = Brushes.Blue;
                PatientSex.Text = "Sex: " + SexInput.Text;
                HasChanges = true;
            }

            SexInput.Visibility = Visibility.Hidden;
        }

        private void InputName_LostFocus(object sender, RoutedEventArgs e)
        {
            var x = FocusManager.GetFocusedElement(App.Current.MainWindow) as TextBox;

            if (x == null)
            {
                DoneInputName();
                return;
            }

            var y = (x.Parent as Grid);

            if (y == null)
            {
                DoneInputName();
                return;
            }

            var z = (y.Parent) as InputText;

            if (z == null || InputName.Children.Contains(z))
            {
                return;
            }
            else
            {
                DoneInputName();
            }
        }

        private void DoneInputName()
        {
            InputName.Visibility = Visibility.Hidden;

            if (FNameInput.TextField.Text != FNameInput.Hint)
                Fname = FNameInput.TextField.Text;

            if (MNameInput.TextField.Text != MNameInput.Hint)
                Mnames = MNameInput.TextField.Text;

            if (LNameInput.TextField.Text != LNameInput.Hint)
                Lname = LNameInput.TextField.Text;

            if (Fname != patient.FirstName || Mnames != patient.MiddleName || Lname != patient.LastName)
            {
                PatientName.Text = Lname + ", " + Fname + ", " + Mnames.TrimStart(new char[] { ' ', '\t' })[0] + ".";
                PatientName.Foreground = Brushes.Blue;
                HasChanges = true;
            }

            PatientName.Visibility = Visibility.Visible;
        }

        private void InputName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                DoneInputName();
            }
            else if (e.Key == Key.Escape)
            {
                InputName.Visibility = Visibility.Hidden;
                PatientName.Visibility = Visibility.Visible;
            }
        }
    }
}
