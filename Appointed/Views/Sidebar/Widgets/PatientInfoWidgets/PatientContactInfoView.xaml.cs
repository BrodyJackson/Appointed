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
using System.Net.Mail;

namespace Appointed.Views.Sidebar.Widgets.PatientInfoWidgets
{
    /// <summary>
    /// Interaction logic for PatientContactInfoView.xaml
    /// </summary>
    public partial class PatientContactInfoView : UserControl
    {
        string emptyFieldText = "(None)";
        public bool HasChanges { get; set; }

        private bool HasHomePhone { get; set; }
        private bool HasCellPhone { get; set; }
        private bool HasWorkPhone { get; set; }
        private bool HasEmail { get; set; }

        public bool HasContactMethod
        {
            get
            {
                return HasHomePhone || HasCellPhone || HasWorkPhone || HasEmail;
            }
        }


        Patient p;

        public PatientContactInfoView()
        {
            InitializeComponent();

            this.Loaded += PatientContactInfoView_Loaded;

            HasChanges = false;
            HasHomePhone = false;
            HasCellPhone = false;
            HasWorkPhone = false;
            HasEmail = false;
        }

        private void PatientContactInfoView_Loaded(object sender, RoutedEventArgs e)
        {
            p = ((App.Current.MainWindow as Home).DataContext as DayInformationViewModel).PVM.ActivePatient;

            if (p.Phone != null && p.Phone != "")
            {
                PatientHomePhone.Text = p.Phone;
                HasHomePhone = true;
            }
            else
                PatientHomePhone.Text = "(None)";

            if (p.Cell != null && p.Cell != "")
            {
                PatientCellPhone.Text = p.Cell;
                HasCellPhone = true;
            }
            else
                PatientCellPhone.Text = "(None)";

            if (p.Business != null && p.Business != "")
            {
                PatientWorkPhone.Text = p.Phone;
                HasWorkPhone = true;
            }
            else
                PatientWorkPhone.Text = "(None)";

            if (p.Email != null && p.Email != "")
            {
                PatientEmail.Text = p.Email;
                HasEmail = true;
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
                PatientHomePhone.Visibility = Visibility.Hidden;
                PatientHomePhoneInput.TextField.Text = PatientHomePhone.Text;
                PatientHomePhoneInput.TextField.Focus();
            }
            else if (t.Name == "PatientCellPhone")
            {
                PatientCellPhoneInput.Visibility = Visibility.Visible;
                PatientCellPhone.Visibility = Visibility.Hidden;
                PatientCellPhoneInput.TextField.Text = PatientCellPhone.Text;
                PatientCellPhoneInput.TextField.Focus();
            }
            else if (t.Name == "PatientWorkPhone")
            {
                PatientWorkPhoneInput.Visibility = Visibility.Visible;
                PatientWorkPhone.Visibility = Visibility.Hidden;
                PatientWorkPhoneInput.TextField.Text = PatientWorkPhone.Text;
                PatientWorkPhoneInput.TextField.Focus();
            }
            else
            {
                PatientEmailInput.Visibility = Visibility.Visible;
                PatientEmail.Visibility = Visibility.Hidden;
                PatientEmailInput.TextField.Text = PatientEmail.Text;
                PatientEmailInput.TextField.Focus();
            }
        }

        private bool IsPhoneNumberValid(InputText number)
        {
            return number.TextField.Text.Length >= 14 && number.TextField.Text != number.Hint;
        }

        private void PatientHomePhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientHomePhoneInput.TextField.Text;

            if (IsPhoneNumberValid(PatientHomePhoneInput) || field == emptyFieldText)
            {
                if (field != p.Phone)
                {
                    PatientHomePhone.Text = field;
                    PatientHomePhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    HasHomePhone = true;
                }
            }

            if (field == emptyFieldText)
                HasHomePhone = false;

            if (!HasContactMethod)
            {
                MyMessageBox msg = new MyMessageBox();
                msg.Show("Patient must have at least one method of contact.\nContact method changes will not be saved!", "No Contact Methods", MyMessageBox.Buton.Ok, MyMessageBox.Buton.Cancel);

                msg.MessageBoxResult += (s, a) =>
                {
                    if (a.result == MyMessageBox.Result.Cancel)
                    {
                        PatientHomePhoneInput.TextField.Focus();
                    }
                    else
                    {
                        PatientHomePhone.Text = p.Phone;
                        PatientHomePhone.Foreground = Brushes.Black;
                        PatientHomePhone.Visibility = Visibility.Visible;
                        PatientHomePhoneInput.Visibility = Visibility.Hidden;
                        HasHomePhone = true;
                    }
                };
            }
            else
            {
                PatientHomePhone.Visibility = Visibility.Visible;
                PatientHomePhoneInput.Visibility = Visibility.Hidden;
            }
        }

        private void PatientCellPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientCellPhoneInput.TextField.Text;

            if (IsPhoneNumberValid(PatientCellPhoneInput) || field == emptyFieldText)
            {
                if (field != p.Cell)
                {
                    PatientCellPhone.Text = field;
                    PatientCellPhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    HasCellPhone = true;

                }
            }

            if (field == emptyFieldText)
                HasCellPhone = false;

            if (!HasContactMethod)
            {
                MyMessageBox msg = new MyMessageBox();
                msg.Show("Patient must have at least one method of contact.\nContact method changes will not be saved!", "No Contact Methods", MyMessageBox.Buton.Ok, MyMessageBox.Buton.Cancel);

                msg.MessageBoxResult += (s, a) =>
                {
                    if (a.result == MyMessageBox.Result.Cancel)
                    {
                        PatientCellPhoneInput.TextField.Focus();
                    }
                    else
                    {
                        PatientCellPhone.Text = p.Cell;
                        PatientCellPhone.Foreground = Brushes.Black;
                        PatientCellPhone.Visibility = Visibility.Visible;
                        PatientCellPhoneInput.Visibility = Visibility.Hidden;
                        HasCellPhone = true;
                    }
                };
            }
            else
            {
                PatientCellPhone.Visibility = Visibility.Visible;
                PatientCellPhoneInput.Visibility = Visibility.Hidden;
            }
        }

        private void PatientWorkPhoneInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientWorkPhoneInput.TextField.Text;

            if (IsPhoneNumberValid(PatientWorkPhoneInput) || field == emptyFieldText)
            {
                if (field != p.Business)
                {
                    PatientWorkPhone.Text = PatientWorkPhoneInput.TextField.Text;
                    PatientWorkPhone.Foreground = Brushes.Blue;
                    HasChanges = true;
                    PatientWorkPhoneInput.Visibility = Visibility.Hidden;
                    HasWorkPhone = true;
                }
            }

            if (field == emptyFieldText)
                HasWorkPhone = false;

            if (!HasContactMethod)
            {
                MyMessageBox msg = new MyMessageBox();
                msg.Show("Patient must have at least one method of contact.\nContact method changes will not be saved!", "No Contact Methods", MyMessageBox.Buton.Ok, MyMessageBox.Buton.Cancel);

                msg.MessageBoxResult += (s, a) =>
                {
                    if (a.result == MyMessageBox.Result.Cancel)
                    {
                        PatientWorkPhoneInput.TextField.Focus();
                    }
                    else
                    {
                        PatientWorkPhone.Text = p.Business;
                        PatientWorkPhone.Foreground = Brushes.Black;
                        PatientWorkPhone.Visibility = Visibility.Visible;
                        PatientWorkPhoneInput.Visibility = Visibility.Hidden;
                        HasWorkPhone = true;
                    }
                };
            }
            else
            {
                PatientWorkPhone.Visibility = Visibility.Visible;
                PatientWorkPhoneInput.Visibility = Visibility.Hidden;
            }
        }


        private bool IsEmailValid(InputText email)
        {
            try
            {
                new MailAddress(email.TextField.Text);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void PatientEmailInput_LostFocus(object sender, RoutedEventArgs e)
        {
            string field = PatientEmailInput.TextField.Text;

            if (IsEmailValid(PatientEmailInput) || field == emptyFieldText)
            {
                if (field != p.Email)
                {
                    PatientEmail.Text = PatientEmailInput.TextField.Text;
                    PatientEmail.Foreground = Brushes.Blue;
                    HasChanges = true;
                    HasEmail = true;
                    PatientEmailInput.Visibility = Visibility.Hidden;
                }
            }

            if (field == emptyFieldText)
                HasEmail = false;

            if (!HasContactMethod)
            {
                MyMessageBox msg = new MyMessageBox();
                msg.Show("Patient must have at least one method of contact.\nContact method changes will not be saved!", "No Contact Methods", MyMessageBox.Buton.Ok, MyMessageBox.Buton.Cancel);

                msg.MessageBoxResult += (s, a) =>
                {
                    if (a.result == MyMessageBox.Result.Cancel)
                    {
                        PatientEmailInput.TextField.Focus();
                    }
                    else
                    {
                        PatientEmail.Text = p.Email;
                        PatientEmail.Foreground = Brushes.Black;
                        PatientEmail.Visibility = Visibility.Visible;
                        PatientEmailInput.Visibility = Visibility.Hidden;
                        HasEmail = true;
                    }
                };
            }
            else
            {
                PatientEmail.Visibility = Visibility.Visible;
                PatientEmailInput.Visibility = Visibility.Hidden;
            }
        }




    }
}
