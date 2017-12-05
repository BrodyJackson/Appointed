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
    /// Interaction logic for PatientEmergencyContactInfo.xaml
    /// </summary>
    public partial class PatientEmergencyContactInfoView: UserControl
    {
        public bool HasChanges { get; set; }

        public bool ContactPhoneInvalid { get; set; }
        public bool ContactNameInvalid { get; set; }
        public bool ContactRelationInvalid { get; set; }
        public bool HasInvalid
        {
            get { return ContactPhoneInvalid ? true : (ContactNameInvalid ? true : (ContactRelationInvalid ? true : false)); }
            set { }
        }

        Patient p;


        public PatientEmergencyContactInfoView()
        {
            InitializeComponent();

            this.Loaded += PatientEmergencyContactInfoView_Loaded;

            ContactPhoneInvalid = false;
            ContactNameInvalid = false;
            ContactRelationInvalid = false;
            HasChanges = false;
        }


        private void PatientEmergencyContactInfoView_Loaded(object sender, RoutedEventArgs e)
        {
            p = ((App.Current.MainWindow as Home).DataContext as DayInformationViewModel).PVM.ActivePatient;

            if (p.EmergencyContact.EmergencyPhone != null && p.EmergencyContact.EmergencyPhone != "")
                ContactPhone.Text = p.EmergencyContact.EmergencyPhone;
            else
                ContactPhone.Text = "(None)";

            if (p.EmergencyContact.EmergencyName != null && p.EmergencyContact.EmergencyName != "")
                ContactName.Text = p.EmergencyContact.EmergencyName;
            else
                ContactName.Text = "(None)";

            if (p.EmergencyContact.EmergencyRelation != null && p.EmergencyContact.EmergencyRelation != "")
                ContactRelation.Text = p.EmergencyContact.EmergencyRelation;
            else
                ContactRelation.Text = "(None)";
        }


        



        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

            ContactPhoneInput.Visibility = Visibility.Hidden;
            ContactNameInput.Visibility = Visibility.Hidden;
            ContactRelationInput.Visibility = Visibility.Hidden;

            if (t.Name == "ContactName")
            {
                ContactNameInput.Visibility = Visibility.Visible;
                ContactNameInput.TextField.Text = ContactName.Text;
                ContactNameInput.TextField.Focus();
            }
            else if (t.Name == "ContactPhone")
            {
                ContactPhoneInput.Visibility = Visibility.Visible;
                ContactPhoneInput.TextField.Text = ContactPhone.Text;
                ContactPhoneInput.TextField.Focus();
            }
            else
            {
                ContactRelationInput.Visibility = Visibility.Visible;
                ContactRelationInput.TextField.Text = ContactRelation.Text;
                ContactRelationInput.TextField.Focus();
            }
        }



        private void ContactNameInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = ContactNameInput.TextField.Text;

            if (field != p.EmergencyContact.EmergencyName)
            {
                if (field != "Name" && field != "")
                {
                    ContactName.Text = field;
                    ContactName.Foreground = Brushes.Blue;
                    HasChanges = true;
                    ContactNameInvalid = false;
                    ContactNameInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    ContactNameInput.TextField.BorderBrush = Brushes.Red;
                    ContactNameInput.TextField.BorderThickness = new Thickness(1.0);
                    ContactNameInvalid = true;
                }
            }
            else if (field == p.EmergencyContact.EmergencyName)
            {
                ContactName.Text = p.EmergencyContact.EmergencyName;
                ContactName.Foreground = Brushes.Black;
                ContactNameInput.Visibility = Visibility.Hidden;
            }
        }


        private void ContactPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = ContactPhoneInput.TextField.Text;
            field = field.Substring(1);
            field = field.Substring(0, 3) + "-" + field.Substring(5);

            if (field != "(555) 555-5555" && field != p.EmergencyContact.EmergencyPhone)
            {
                if (field.Length == 12 || field.Length == 16)
                {
                    ContactPhone.Text = ContactPhoneInput.TextField.Text;
                    ContactPhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    ContactPhoneInvalid = false;
                    ContactPhoneInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    ContactPhoneInput.TextField.BorderBrush = Brushes.Red;
                    ContactPhoneInput.TextField.BorderThickness = new Thickness(1.0);
                    ContactPhoneInvalid = true;
                }
            }
            else if (field == p.EmergencyContact.EmergencyPhone)
            {
                ContactPhone.Text = p.EmergencyContact.EmergencyPhone;
                ContactPhone.Foreground = Brushes.Black;
                ContactPhoneInput.Visibility = Visibility.Hidden;
            }
        }



        private void ContactRelationInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = ContactRelationInput.TextField.Text;

            if (field != p.EmergencyContact.EmergencyRelation)
            {
                if (field != "Relation" && field != "")
                {
                    ContactRelation.Text = field;
                    ContactRelation.Foreground = Brushes.Blue;
                    HasChanges = true;
                    ContactRelationInvalid = false;
                    ContactRelationInput.Visibility = Visibility.Hidden;
                }
                else
                {
                    ContactRelationInput.TextField.BorderBrush = Brushes.Red;
                    ContactRelationInput.TextField.BorderThickness = new Thickness(1.0);
                    ContactRelationInvalid = true;
                }
            }
            else if (field == p.EmergencyContact.EmergencyRelation)
            {
                ContactRelation.Text = p.EmergencyContact.EmergencyRelation;
                ContactRelation.Foreground = Brushes.Black;
                ContactRelationInput.Visibility = Visibility.Hidden;
            }
        }


    }
}
