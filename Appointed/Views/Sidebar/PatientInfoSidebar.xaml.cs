using Appointed.Classes;
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
using Appointed.ViewModels;
using Appointed.Views.Sidebar.ListItems;

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for PatientInfoSidebar.xaml
    /// </summary>
    public partial class PatientInfoSidebar : UserControl
    {
        public Patient Patient { get; private set; }

        public PatientInfoSidebar(Patient patient)
        {
            InitializeComponent();
            Patient = patient;

            BasicInfo.patient = patient;
            AddrInfo.patient = patient;
            ContactInfo.patient = patient;
            EmergInfo.patient = patient;
            Notes.patient = patient;

            this.Loaded += PatientInfoSidebarLoaded;
        }

        /// <summary>
        /// Returns true if any editable paitent info widget has changes
        /// </summary>
        /// <returns></returns>
        public bool HasChanges()
        {
            return BasicInfo.HasChanges || AddrInfo.HasChanges || ContactInfo.HasChanges || EmergInfo.HasChanges || Notes.HasChanges;
        }




        private void PatientInfoSidebarLoaded(object sender, RoutedEventArgs e)
        {
            PopulateUpcomingAppointments();
        }


        private void PopulateUpcomingAppointments()
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Appointment a;
            ApptHistoryDetail hist;

            foreach (int key in Patient.GetUpcomingAppointmentKeys())
            {
                a = DIVM.AVM._appointmentLookup[key];

                if (a.DateTime >= DateTime.Today)
                {
                    hist = new ApptHistoryDetail();
                    hist.Date.Text = a.DateTimeStr;
                    hist.Doctor.Text = a.DoctorName;
                    hist.Type.Text = a.Type;

                    UpcomingAppts.PastApptList.Children.Add(hist);
                }
            }
        }


        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            if (HasChanges())
            {
                MyMessageBox msgBox = new MyMessageBox();
                msgBox.MessageBoxResult += OnDiscardDecisionMade;
                msgBox.Show
                    (
                        "Are you sure you wish to discard your changes?",
                        "Discard Changes",
                        MyMessageBox.Buton.Yes,
                        MyMessageBox.Buton.No
                    );
            }
            else
            {
                Home h = App.Current.MainWindow as Home;
                h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
            }
        }

        private void OnDiscardDecisionMade(object sender, MessageBoxEventArgs e)
        {
            MyMessageBox.Result r = e.result;

            if (r == MyMessageBox.Result.Yes)
            {
                Home h = App.Current.MainWindow as Home;
                h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
            }
        }
        

        private void OnMouseLeftRelease_Save(object sender, MouseButtonEventArgs e)
        {
            Home h = App.Current.MainWindow as Home;

            if (!HasChanges())
            {
                h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
                return;
            }

            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Patient p = DIVM.PVM.ActivePatient;
            string workString;

            if (BasicInfo.HasChanges)
            {
                if (BasicInfo.FNameInput.TextField.Text != "First Name")
                    p.FirstName = BasicInfo.FNameInput.TextField.Text;
                if (BasicInfo.MNameInput.TextField.Text != "Middle Name(s)")
                    p.LastName = BasicInfo.LNameInput.TextField.Text;
                if (BasicInfo.LNameInput.TextField.Text != "Last Name")
                    p.MiddleName = BasicInfo.MNameInput.TextField.Text;

                workString = BasicInfo.PatientID.Text;
                workString = workString.Substring(workString.IndexOf(":") + 2, 5) + workString.Substring(workString.Length - 3, 3);
                p.HealthID = Int32.Parse(workString);

                workString = BasicInfo.PatientSex.Text;
                workString = workString.Substring(workString.IndexOf(":") + 2);
                p.Sex = Patient.SexStringToEnum(workString);

                workString = BasicInfo.PatientBirthday.Text;
                workString = workString.Substring(workString.IndexOf(":") + 2);
                p.BirthDate = DateTime.Parse(workString);
            }

            if (AddrInfo.HasChanges)
            {
                p.Street = AddrInfo.PatientStreetAddress.Text;

                workString = AddrInfo.PatientRegion.Text;
                p.City = workString.Substring(0, workString.IndexOf(","));
                workString = workString.Substring(workString.IndexOf(",") + 2);
                p.Province = Patient.ProvinceStringToEnum(workString);
                p.PostalCode = AddrInfo.PatientPostal.Text;
            }

            if (ContactInfo.HasChanges)
            {            
                p.Phone = ContactInfo.PatientHomePhone.Text;
                p.Cell = ContactInfo.PatientCellPhone.Text;
                p.Business =ContactInfo.PatientWorkPhone.Text;
                p.Email = ContactInfo.PatientEmail.Text;
            }

            if (EmergInfo.HasChanges)
            {
                p.EmergencyContact.EmergencyName =EmergInfo.ContactName.Text;
                p.EmergencyContact.EmergencyRelation = EmergInfo.ContactRelation.Text;                
                p.EmergencyContact.EmergencyPhone = EmergInfo.ContactPhone.Text;
            }

            p.Notes = Notes.CommentBox.Text;

            h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
        }

    }
}
