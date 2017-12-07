using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views.Controls;
using Appointed.Views.Sidebar;
using System;
using System.Windows.Media;
using System.Linq;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Appointed.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewPatientDialog.xaml
    /// </summary>
    public partial class NewPatientDialog : Window
    {

        public enum EXIT_ACTION { SAVE, SAVEBOOK, DISCARD };

        public EXIT_ACTION ExitAction { get; private set; }

        private Patient _patient;

        private bool forceClose = false;

        public NewPatientDialog()
        {
            InitializeComponent();

            ExitAction = EXIT_ACTION.DISCARD;

            //Disable/Enable left/right keys from moving schedule
            Notes.GotFocus += (s, e) => { App.AllowArrowKeyCalendarNavigation = false; };
            Notes.LostFocus += (s, e) => { App.AllowArrowKeyCalendarNavigation = true; };

            //Valid Input Handlers
            HealthID.TextField.TextChanged += HealthID_Changed;
            FirstName.TextField.TextChanged += FirstName_Changed;
            LastName.TextField.TextChanged += LastName_Changed;
            Address.TextField.TextChanged += Address_Changed;
            City.TextField.TextChanged += City_Changed;
            ContactName.TextField.TextChanged += ContactName_Changed;
            ContactRelation.TextField.TextChanged += ContactRelation_Changed;
            ContactPhone.TextField.TextChanged += ContactPhone_Changed;

            Closing += NewPatientDialog_Closing;

            DiscardBtn.Click += (object sender, RoutedEventArgs e) => { Close(); };

            SaveBtn.Click += (object sender, RoutedEventArgs e) =>
            {
                if (SavePatient())
                {
                    Close();
                }
            };

            SaveBookBtn.Click += (object sender, RoutedEventArgs e) =>
            {
                if (SavePatient())
                {
                    ExitAction = EXIT_ACTION.SAVEBOOK;
                    (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient = new Patient(_patient);
                    (App.Current.MainWindow as Home).SidebarView.SetSidebarView(new NewAppointmentSidebar());
                    Close();
                }
            };
        }

        #region InputTextChanged Handlers

        private void ContactPhone_Changed(object sender, TextChangedEventArgs e)
        {
            if (IsPhoneNumberValid(ContactPhone) && !ContactPhone.Valid && ContactPhone.TextField.Text != ContactPhone.Hint && !String.IsNullOrWhiteSpace(ContactPhone.TextField.Text))
            {
                ContactPhone.MarkValid();
            }
        }

        private void FirstName_Changed(object sender, TextChangedEventArgs e)
        {
            if (!FirstName.Valid && FirstName.TextField.Text != FirstName.Hint && !String.IsNullOrWhiteSpace(FirstName.TextField.Text))
            {
                FirstName.MarkValid();
            }
        }

        private void LastName_Changed(object sender, TextChangedEventArgs e)
        {
            if (!LastName.Valid && LastName.TextField.Text != LastName.Hint && !String.IsNullOrWhiteSpace(LastName.TextField.Text))
            {
                LastName.MarkValid();
            }
        }

        private void Address_Changed(object sender, TextChangedEventArgs e)
        {
            if (!Address.Valid && Address.TextField.Text != Address.Hint && !String.IsNullOrWhiteSpace(Address.TextField.Text))
            {
                Address.MarkValid();
            }
        }

        private void City_Changed(object sender, TextChangedEventArgs e)
        {
            if (!City.Valid && City.TextField.Text != City.Hint && !String.IsNullOrWhiteSpace(City.TextField.Text))
            {
                City.MarkValid();
            }
        }

        private void ContactName_Changed(object sender, TextChangedEventArgs e)
        {
            if (!ContactName.Valid && ContactName.TextField.Text != ContactName.Hint && !String.IsNullOrWhiteSpace(ContactName.TextField.Text))
            {
                ContactName.MarkValid();
            }
        }

        private void ContactRelation_Changed(object sender, TextChangedEventArgs e)
        {
            if (!ContactRelation.Valid && ContactRelation.TextField.Text != ContactRelation.Hint && !String.IsNullOrWhiteSpace(ContactRelation.TextField.Text))
            {
                ContactRelation.MarkValid();
            }
        }

        private void HealthID_Changed(object sender, TextChangedEventArgs e)
        {
            if (!IsHealthcareIDValid() && HealthID.Valid)
            {
                HealthID.MarkInvalid();
                WarningPopups.HCIDTakenMessageBox msgBox = new WarningPopups.HCIDTakenMessageBox();
                msgBox.Message.Text = "A patient already exists with the Healthcare ID '" + HealthID.TextField.Text + "'!\n\nWould you like to discard entered information and\nSearch for this patient instead of creating a new one, or change the Healthcare ID?";
                msgBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                msgBox.SearchBtn.Click += (s, v) =>
                {

                    Application.Current.MainWindow.OpacityMask = null;
                    Application.Current.MainWindow.Opacity = 1.0;
                    Application.Current.MainWindow.IsHitTestVisible = true;

                    msgBox.Close();
                    (App.Current.MainWindow as Home).SidebarView.SetSidebarView(new SearchResultsSidebar(HealthID.TextField.Text));
                    forceClose = true;
                    Close();
                };
                msgBox.NewIDBtn.Click += (s, v) =>
                {
                    Application.Current.MainWindow.OpacityMask = null;
                    Application.Current.MainWindow.Opacity = 1.0;
                    Application.Current.MainWindow.IsHitTestVisible = true;
                    msgBox.Close();
                };
                msgBox.Closed += (s, v) =>
                {
                    Application.Current.MainWindow.OpacityMask = null;
                    Application.Current.MainWindow.Opacity = 1.0;
                    Application.Current.MainWindow.IsHitTestVisible = true;

                    HealthID.TextField.Focus();
                };

                Application.Current.MainWindow.OpacityMask = Brushes.Black;
                Application.Current.MainWindow.Opacity = 0.3;
                Application.Current.MainWindow.IsHitTestVisible = false;
                msgBox.ShowDialog();
            }
            else
            {
                HealthID.MarkValid();
            }
        }

        #endregion

        #region InputValidators

        private bool IsPhoneNumberValid(InputText number)
        {
            return number.TextField.Text.Length >= 14 && number.TextField.Text != number.Hint;
        }

        private bool IsPostalCodeValid()
        {
            // XXX XXX
            return (PostalCode.TextField.Text.Length == 7);

        }

        private bool IsHealthcareIDValid()
        {
            int id;

            if (HealthID.TextField.Text == HealthID.Hint)
            {
                return true;
            }
            else if (Int32.TryParse(new String(HealthID.TextField.Text.Where(x => Char.IsDigit(x)).ToArray()), out id))
            {
                return !(App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.GetPatientDatabaseModel().GetPatientDictionary().ContainsKey(id);
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void NewPatientDialog_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ExitAction == EXIT_ACTION.DISCARD)
            {
                if (!VerifyDiscard())
                {
                    e.Cancel = true;
                }
            }
        }

        private bool VerifyDiscard()
        {
            if (forceClose) return true;

            MyMessageBox msg = new MyMessageBox();
            msg.Show("Are you sure you wish to discard the new patient?", "Discard New Patient", MyMessageBox.Buton.Yes, MyMessageBox.Buton.No);

            msg.MessageBoxResult += (s, e) =>
            {
                if (e.result == MyMessageBox.Result.Yes)
                {
                    forceClose = true;
                    Close();
                }
            };

            return false;
        }

        /// <summary>
        /// Returns true on successful patient creation, faslse otherwise
        /// </summary>
        /// <returns></returns>
        private bool SavePatient()
        {
            if (ValidateFields())
            {
                //Create Patient
                _patient = new Patient
                {
                    BirthDate = Birthdate.DateSelected.Value,
                    Business = ExtractValue(BusinessPhone),
                    Cell = ExtractValue(CellPhone),
                    City = City.TextField.Text,
                    Email = ExtractValue(Email),
                    FirstName = FirstName.TextField.Text,
                    HealthID = int.Parse(new String(HealthID.TextField.Text.Where(x => Char.IsDigit(x)).ToArray())),
                    LastName = LastName.TextField.Text,
                    MiddleName = ExtractValue(MiddleNames),
                    Phone = ExtractValue(HomePhone),
                    PostalCode = PostalCode.TextField.Text,
                    Province = Patient.ProvinceStringToEnum(Province.Text),
                    Sex = Patient.SexStringToEnum(Sex.Text),
                    Street = Address.TextField.Text,
                    Notes = Notes.Text,

                    EmergencyContact = new EmergencyContact()
                    {
                        EmergencyName = ContactName.TextField.Text,
                        EmergencyPhone = ContactPhone.TextField.Text,
                        EmergencyRelation = ContactRelation.TextField.Text
                    }
                };

                //Add patient to db
                (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.AddPatient(_patient);

                //Set Exit Action
                ExitAction = EXIT_ACTION.SAVE;

                return true;
            }
            else
            {
                //WarningPopups.InvalidNewPatientDialog msgBox = new WarningPopups.InvalidNewPatientDialog();
                //msgBox.Message.TextAlignment = TextAlignment.Center;
                //msgBox.Message.Text = "Unable to create a new patient!\nPlease ensure all highlighted fields are completed correctly.";
                //msgBox.OkBtn.Click += (s, v) => { msgBox.Close(); };
                //msgBox.ShowDialog();

                MyMessageBox msg = new MyMessageBox();
                msg.Show("Unable to create a new patient!\n\nPlease ensure all highlighted fields are completed correctly.", "Unable to Create Patient", MyMessageBox.Buton.Ok);

            }

            return false;
        }

        private string ExtractValue(InputText text)
        {
            if (text.TextField.Text == text.Hint)
            {
                return "";
            }
            else
            {
                return text.TextField.Text;
            }
        }

        /// <summary>
        /// Marks invalid/valid feilds by calling their Mark(In)Valid functions
        /// returns true if all fields contain valid data, false otherwise.
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool allValid = true;

            if (FirstName.TextField.Text == FirstName.Hint)
            {
                FirstName.MarkInvalid();
                allValid = false;
            }
            else
            {
                FirstName.MarkValid();
            }

            if (LastName.TextField.Text == LastName.Hint)
            {
                LastName.MarkInvalid();
                allValid = false;
            }
            else
            {
                LastName.MarkValid();
            }

            if (!IsHealthcareIDValid() || HealthID.TextField.Text == HealthID.Hint || HealthID.TextField.Text.Length != 9)
            {
                HealthID.MarkInvalid();
                allValid = false;
            }
            else
            {
                HealthID.MarkValid();
            }

            if (!Birthdate.DateSelected.HasValue)
            {
                Birthdate.InputText.MarkInvalid();
                allValid = false;
            }
            else
            {
                Birthdate.InputText.MarkValid();
            }

            if (Address.TextField.Text == Address.Hint)
            {
                Address.MarkInvalid();
                allValid = false;
            }
            else
            {
                Address.MarkValid();
            }

            if (City.TextField.Text == City.Hint)
            {
                City.MarkInvalid();
                allValid = false;
            }
            else
            {
                City.MarkValid();
            }

            if (!IsPostalCodeValid())
            {
                PostalCode.MarkInvalid();
                allValid = false;
            }
            else
            {
                PostalCode.MarkValid();
            }

            int contactMethodCount = 0;

            //Check for at least one contact method, and ensure it is correct
            if (HomePhone.TextField.Text != HomePhone.Hint && !IsPhoneNumberValid(HomePhone))
            {
                HomePhone.MarkInvalid();
                allValid = false;
            }
            else if (HomePhone.TextField.Text == HomePhone.Hint)
            {
                HomePhone.MarkValid();
            }
            else
            {
                HomePhone.MarkValid();
                contactMethodCount++;
            }

            //Optional Business Phone, if it is filled in, ensure it is at least a 10 digit number
            if (BusinessPhone.TextField.Text != BusinessPhone.Hint && !IsPhoneNumberValid(BusinessPhone))
            {
                BusinessPhone.MarkInvalid();
                allValid = false;
            }
            else if (BusinessPhone.TextField.Text == BusinessPhone.Hint)
            {
                BusinessPhone.MarkValid();
            }
            else
            {
                BusinessPhone.MarkValid();
                contactMethodCount++;
            }

            //Optional Cell Phone, if it is filled in, ensure it is at least a 10 digit number
            if (CellPhone.TextField.Text != CellPhone.Hint && CellPhone.TextField.Text.Length < 14)
            {
                CellPhone.MarkInvalid();
                allValid = false;
            }
            else if (CellPhone.TextField.Text == CellPhone.Hint)
            {
                CellPhone.MarkValid();
            }
            else
            {
                CellPhone.MarkValid();
                contactMethodCount++;
            }

            //Email Format Verification
            if (Email.TextField.Text != Email.Hint)
            {
                try
                {
                    new MailAddress(Email.TextField.Text);
                    Email.MarkValid();
                    contactMethodCount++;
                }
                catch
                {
                    Email.MarkInvalid();
                    allValid = false;
                }
            }

            if (ContactName.TextField.Text == ContactName.Hint)
            {
                ContactName.MarkInvalid();
                allValid = false;
            }
            else
            {
                ContactName.MarkValid();
            }

            if (ContactRelation.TextField.Text == ContactRelation.Hint)
            {
                ContactRelation.MarkInvalid();
                allValid = false;
            }
            else
            {
                ContactRelation.MarkValid();
            }

            if (!IsPhoneNumberValid(ContactPhone))
            {
                ContactPhone.MarkInvalid();
                allValid = false;
            }
            else
            {
                ContactPhone.MarkValid();
            }

            if (contactMethodCount < 1)
            {
                ContactAstrix.Visibility = Visibility.Hidden;
                ContactAstrixTxt.Visibility = Visibility.Hidden;
                ContactMethodReqText.Visibility = Visibility.Visible;
                allValid = false;
            }
            else
            {
                ContactAstrix.Visibility = Visibility.Visible;
                ContactAstrixTxt.Visibility = Visibility.Visible;
                ContactMethodReqText.Visibility = Visibility.Collapsed;
            }

            return allValid;
        }
    }
}
