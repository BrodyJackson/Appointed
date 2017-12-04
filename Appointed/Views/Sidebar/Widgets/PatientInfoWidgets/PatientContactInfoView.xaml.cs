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
    /// Interaction logic for PatientContactInfoView.xaml
    /// </summary>
    public partial class PatientContactInfoView : UserControl
    {
        public PatientContactInfoView()
        {
            InitializeComponent();
        }

        private void OnClickInputText(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = sender as TextBlock;

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

        private void PatientWorkPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientWorkPhoneInput.TextField.Text;
            if (field != "(555) 555 - 5555" && field != "")
                PatientWorkPhone.Text = field;

            PatientWorkPhoneInput.Visibility = Visibility.Hidden;
        }

        private void PatientCellPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientCellPhoneInput.TextField.Text;
            if (field != "(555) 555 - 5555" && field != "")
                PatientCellPhone.Text = field;

            PatientCellPhoneInput.Visibility = Visibility.Hidden;
        }

        private void PatientHomePhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientHomePhoneInput.TextField.Text;
            if (field != "(555) 555 - 5555" && field != "")
                PatientHomePhone.Text = field;

            PatientHomePhoneInput.Visibility = Visibility.Hidden;
        }

        private void PatientEmailInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientEmailInput.TextField.Text;
            if (field != "(555) 555 - 5555" && field != "")
                PatientEmail.Text = field;

            PatientEmailInput.Visibility = Visibility.Hidden;
        }
    }
}
