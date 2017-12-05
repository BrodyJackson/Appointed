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

namespace Appointed.Views.Sidebar.Widgets.PatientInfoWidgets
{
    /// <summary>
    /// Interaction logic for PatientEmergencyContactInfo.xaml
    /// </summary>
    public partial class PatientEmergencyContactInfoView: UserControl
    {
        public PatientEmergencyContactInfoView()
        {
            InitializeComponent();
        }



        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

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

            if (field != "Name" && field != "")
                ContactName.Text = field;

            ContactNameInput.Visibility = Visibility.Hidden;
        }

        private void ContactPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = ContactPhoneInput.TextField.Text;

            if (field != "Name" && field != "")
                ContactPhone.Text = field;

            ContactPhoneInput.Visibility = Visibility.Hidden;
        }

        private void ContactRelationInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = ContactRelationInput.TextField.Text;

            if (field != "Name" && field != "")
                ContactRelation.Text = field;

            ContactRelationInput.Visibility = Visibility.Hidden;
        }
    }
}
