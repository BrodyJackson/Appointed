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
        }

        /// <summary>
        /// Returns true if any editable paitent info widget has changes
        /// </summary>
        /// <returns></returns>
        public bool HasChanges()
        {
            return BasicInfo.HasChanges || AddrInfo.HasChanges || ContactInfo.HasChanges || EmergInfo.HasChanges;
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
            if (!HasChanges())
            {
                Home h = App.Current.MainWindow as Home;
                h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
            }

            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Patient p = DIVM.PVM.ActivePatient;

            if (BasicInfo.HasChanges)
            {
                string workString;
                workString = BasicInfo.PatientName.Text;
                int fNameLen = workString.LastIndexOf(",") - (workString.IndexOf(',') + 2);
                p.FirstName = workString.Substring(workString.IndexOf(',') + 2, fNameLen);
                p.LastName = workString.Substring(0, workString.IndexOf(","));
                p.MiddleName = workString.Substring(workString.LastIndexOf(",") + 2);

                p.HealthID = Int32.Parse(BasicInfo.PatientID.Text);
                p.Sex = (BasicInfo.SexInput.SelectedIndex == 0 ? Patient.SEX.MALE :
                        (BasicInfo.SexInput.SelectedIndex == 1 ? Patient.SEX.FEMALE : Patient.SEX.OTHER));
                p.BirthDate = DateTime.Parse(BasicInfo.PatientBirthday.Text);
            }
            else if (AddrInfo.HasChanges)
            {
            }
            else if (ContactInfo.HasChanges)
            {
            }
            else
            { 
            }

        }


        //<Widgets:PatientBasicInfoView
        //        x:Name="BasicInfo"
        //        DockPanel.Dock="Top"
        //        Margin="0,4,0,0"
        //        Height="auto" />

        //    <Widgets:PatientAddressInfoView
        //        x:Name="AddrInfo"
        //        DockPanel.Dock="Top"
        //        Margin="0,4,0,0"
        //        Height="auto" />

        //    <Widgets:PatientContactInfoView
        //        x:Name="ContactInfo"
        //        DockPanel.Dock="Top"
        //        Margin="0,4,0,0"
        //        Height="auto" />

        //    <Widgets:PatientEmergencyContactInfoView
        //        x:Name="EmergInfo"
        //        DockPanel.Dock="Top"
        //        Margin="0,4,0,0"
        //        Height="auto" />

        //    <Widgets:PatientNotesView
        //        x:Name="Notes"
        //        DockPanel.Dock="Top"
        //        Margin="0,4,0,0"
        //        Height="auto" />

        //    <Widgets:PatientUpcomingApptView
        //        DockPanel.Dock="Top"
        //        Margin= "0,4,0,0"
        //        MaxHeight= "150"
        //        MinHeight= "150"
        //        Height= "auto" />

        //    < Widgets:PatientApptHistoryView
        //        DockPanel.Dock= "Top"
        //        Margin= "0,4,0,0"
        //        MaxHeight= "300"
        //        MinHeight= "300"
        //        Height= "auto" />










    }
}
