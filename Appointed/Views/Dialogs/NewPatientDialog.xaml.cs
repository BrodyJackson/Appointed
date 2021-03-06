﻿using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views.Controls;
using Appointed.Views.Sidebar;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

        public NewPatientDialog()
        {
            InitializeComponent();

            ExitAction = EXIT_ACTION.DISCARD;

            //Valid Input Handlers
            HealthID.TextField.TextChanged += HealthID_Changed;

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
                if(SavePatient())
                {
                    ExitAction = EXIT_ACTION.SAVEBOOK;
                    (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient = _patient;
                    (App.Current.MainWindow as Home).SidebarView.SetSidebarView(new NewAppointmentSidebar());
                    Close();
                }
            };
        }

        private bool IsPhoneNumberValid(InputText number)
        {
            return number.TextField.Text.Length >= 14 && number.TextField.Text != number.Hint;
        }

        private bool IsPostalCodeValid()
        {
            // XXX XXX
            return (PostalCode.TextField.Text.Length == 7);

        }

        private void HealthID_Changed(object sender, TextChangedEventArgs e)
        {
            if (!IsHealthcareIDValid())
            {
                HealthID.MarkInvalid();
                MessageBox.Show("A patient with this Healthcare ID: " + HealthID.TextField.Text + " already exists!", "Invalid Healthcare ID", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                HealthID.TextField.Text = "";
                HealthID.TextField.Focus();
            }
            else
            {
                HealthID.MarkValid();
            }
        }

        private bool IsHealthcareIDValid()
        {
            if (HealthID.TextField.Text == HealthID.Hint)
            {
                return true;
            }
            else if (int.TryParse(new String(HealthID.TextField.Text.Where(x => Char.IsDigit(x)).ToArray()), out int id))
            {
                return !(App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.GetPatientDatabaseModel().GetPatientDictionary().ContainsKey(id);
            }
            else
            {
                return true;
            }
        }

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
            MessageBoxResult res = MessageBox.Show("Are you sure you wish to discard patient info?", "Discard New Patient", MessageBoxButton.YesNo, MessageBoxImage.None, MessageBoxResult.No);

            return res == MessageBoxResult.Yes ? true : false;
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
                    Phone = HomePhone.TextField.Text,
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
                MessageBox.Show("Please ensure all highlighted fields are filled correctly!", "Incomplete Patient Data", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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

            if (!IsHealthcareIDValid() || HealthID.TextField.Text == HealthID.Hint)
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

            if (!IsPhoneNumberValid(HomePhone))
            {
                HomePhone.MarkInvalid();
                allValid = false;
            }
            else
            {
                HomePhone.MarkValid();
            }

            //Optional Business Phone, if it is filled in, ensure it is at least a 10 digit number
            if (BusinessPhone.TextField.Text != BusinessPhone.Hint && BusinessPhone.TextField.Text.Length < 14)
            {
                BusinessPhone.MarkInvalid();
                allValid = false;
            }
            else
            {
                BusinessPhone.MarkValid();
            }

            //Optional Cell Phone, if it is filled in, ensure it is at least a 10 digit number
            if (CellPhone.TextField.Text != CellPhone.Hint && CellPhone.TextField.Text.Length < 14)
            {
                CellPhone.MarkInvalid();
                allValid = false;
            }
            else
            {
                CellPhone.MarkValid();
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

            return allValid;
        }
    }
}


/*
    First Name*
    Middle Name
    Last Name*

    Health ID*
    Birth*
    
    Address*
    City*
    Postal*

    Home*
    Business
    Cell
    email

    contact name*
    contact relation*
    contact phone*
     
     */
