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
using Appointed.Views.Dialogs;
using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views.Controls;

namespace Appointed.Views.Sidebar.Widgets.PatientInfoWidgets
{
    /// <summary>
    /// Interaction logic for PatientContactInfoView.xaml
    /// </summary>
    public partial class PatientContactInfoView : UserControl
    {
        string hint = "(555) 555 - 5555";
        public bool HasChanges { get; set; }

        public bool HomePhoneInvalid { get; set; }
        public bool CellPhoneInvalid { get; set; }
        public bool WorkPhoneInvalid { get; set; }
        public bool EmailInvalid { get; set; }
        public bool HasInvalid
        {
            get { return HomePhoneInvalid ? true : (CellPhoneInvalid ? true : (WorkPhoneInvalid ? true : (EmailInvalid ? true : false))); }
            set { }
        }


        Patient p;

        public PatientContactInfoView()
        {
            InitializeComponent();

            this.Loaded += PatientContactInfoView_Loaded;

            HasChanges = false;
            HomePhoneInvalid = false;
            CellPhoneInvalid = false;
            WorkPhoneInvalid = false;
            EmailInvalid = false;
        }

        private void PatientContactInfoView_Loaded(object sender, RoutedEventArgs e)
        {
            p = ((App.Current.MainWindow as Home).DataContext as DayInformationViewModel).PVM.ActivePatient;

            if (p.Phone != null && p.Phone != "")
            {
                PatientHomePhone.Text = p.Phone;
                //if (p.Phone.Length != 23)
                //    PatientHomePhoneInput.Mask = InputText.MASK.PHONENUMBER_WITHEXT;
            }
            else
                PatientHomePhone.Text = "(None)";

            if (p.Cell != null && p.Cell != "")
            {
                PatientCellPhone.Text = p.Cell;
                //if (p.Phone.Length == 23)
                //    PatientCellPhoneInput.Mask = InputText.MASK.PHONENUMBER_WITHEXT;
            }
            else
                PatientCellPhone.Text = "(None)";

            if (p.Business != null && p.Business != "")
            {
                PatientWorkPhone.Text = p.Phone;
                //if (p.Phone.Length == 23)
                //    PatientWorkPhoneInput.Mask = InputText.MASK.PHONENUMBER_WITHEXT;
            }
            else
                PatientWorkPhone.Text = "(None)";

            if (p.Email != null && p.Email != "")
            {
                PatientEmail.Text = p.Email;
                //if (p.Phone.Length == 23)
                //    PatientEmailInput.Mask = InputText.MASK.PHONENUMBER_WITHEXT;
            }
            else
                PatientEmail.Text = "(None)";
        }

        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

            PatientWorkPhoneInput.Visibility = Visibility.Hidden;
            PatientCellPhoneInput.Visibility = Visibility.Hidden;
            PatientHomePhoneInput.Visibility = Visibility.Hidden;
            PatientEmailInput.Visibility = Visibility.Hidden;

            if (t.Name == "PatientHomePhone")
            {
                PatientHomePhoneInput.Visibility = Visibility.Visible;
                PatientHomePhoneInput.TextField.Text = PatientHomePhone.Text;
                PatientHomePhoneInput.TextField.Focus();
            }
            else if (t.Name == "PatientCellPhone")
            {
                PatientCellPhoneInput.Visibility = Visibility.Visible;
                PatientCellPhoneInput.TextField.Text = PatientCellPhone.Text;
                PatientCellPhoneInput.TextField.Focus();
            }
            else if (t.Name == "PatientWorkPhone")
            {
                PatientWorkPhoneInput.Visibility = Visibility.Visible;
                PatientWorkPhoneInput.TextField.Text = PatientWorkPhone.Text;
                PatientWorkPhoneInput.TextField.Focus();
            }
            else
            {
                PatientEmailInput.Visibility = Visibility.Visible;
                PatientEmailInput.TextField.Text = PatientEmail.Text;
                PatientEmailInput.TextField.Focus();
            }
        }

        private void PatientHomePhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientHomePhoneInput.TextField.Text;
            field = field.Substring(1);
            field = field.Substring(0, 3) + "-" + field.Substring(5);

            if (field != hint && field != p.Phone)
            {
                if (field.Length == 12 || field.Length == 16)
                {
                    PatientHomePhone.Text = PatientHomePhoneInput.TextField.Text;
                    PatientHomePhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    HomePhoneInvalid = false;
                    PatientHomePhoneInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    PatientHomePhoneInput.TextField.BorderBrush = Brushes.Red;
                    PatientHomePhoneInput.TextField.BorderThickness = new Thickness(1.0);
                    HomePhoneInvalid = true;
                }
            }
            else if (field == p.Phone)
            {
                PatientHomePhone.Text = p.Phone;
                PatientHomePhone.Foreground = Brushes.Black;
                PatientHomePhoneInput.Visibility = Visibility.Hidden;
            }
        }

        private void PatientCellPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientCellPhoneInput.TextField.Text;
            field = field.Substring(1);
            field = field.Substring(0, 3) + "-" + field.Substring(5);

            if (field != hint && field != p.Cell)
            {
                if (field.Length == 12 || field.Length == 16)
                {
                    PatientCellPhone.Text = PatientCellPhoneInput.TextField.Text;
                    PatientCellPhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    CellPhoneInvalid = false;
                    PatientCellPhoneInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    PatientCellPhoneInput.TextField.BorderBrush = Brushes.Red;
                    PatientCellPhoneInput.TextField.BorderThickness = new Thickness(1.0);
                    CellPhoneInvalid = true;
                }
            }
            else if (field == p.Cell)
            {
                PatientCellPhone.Text = p.Cell;
                PatientCellPhone.Foreground = Brushes.Black;
                PatientCellPhoneInput.Visibility = Visibility.Hidden;
            }
        }

        private void PatientWorkPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientWorkPhoneInput.TextField.Text;
            field = field.Substring(1);
            field = field.Substring(0, 3) + "-" + field.Substring(5);

            if (field != hint && field != p.Business)
            {
                if (field.Length == 12 || field.Length == 16)
                {
                    PatientWorkPhone.Text = PatientWorkPhoneInput.TextField.Text;
                    PatientWorkPhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    WorkPhoneInvalid = false;
                    PatientWorkPhoneInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    PatientWorkPhoneInput.TextField.BorderBrush = Brushes.Red;
                    PatientWorkPhoneInput.TextField.BorderThickness = new Thickness(1.0);
                    WorkPhoneInvalid = true;
                }
            }
            else if (field == p.Business)
            {
                PatientWorkPhone.Text = p.Business;
                PatientWorkPhone.Foreground = Brushes.Black;
                PatientWorkPhoneInput.Visibility = Visibility.Hidden;
            }
        }


        private void PatientEmailInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientEmailInput.TextField.Text;

            if (field != hint && field != p.Email)
            {
                if (field.Length > 0 && field.Contains("@") && field.Contains(".com"))
                {
                    PatientEmail.Text = PatientEmailInput.TextField.Text;
                    PatientEmail.Foreground = Brushes.Blue;
                    HasChanges = true;
                    EmailInvalid = true;
                    PatientEmailInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    PatientEmailInput.TextField.BorderBrush = Brushes.Red;
                    PatientEmailInput.TextField.BorderThickness = new Thickness(1.0);
                    EmailInvalid = true;
                }
            }
            else if (field == p.Email)
            {
                PatientEmail.Text = p.Email;
                PatientEmail.Foreground = Brushes.Black;
                PatientEmailInput.Visibility = Visibility.Hidden;
            }
        }




    }
}
