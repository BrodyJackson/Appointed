﻿using System;
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
using Appointed.Views;
using Appointed.ViewModels;
using Appointed.Classes;
using Appointed.Views.Sidebar;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AppointmentDetailsSidebar : UserControl
    {
        public AppointmentDetailsSidebar()
        {
            InitializeComponent();
        }


        private void OnMouseLeftRelease_CheckIn(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Button checkIn = sender as Button;

            if (checkIn.Content.ToString() == "Check-In")
            { 
                DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)].Arrived = true;
                DIVM.AVM._activeAppointment.Arrived = true;
            }
            else
            {
                DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)].Arrived = false;
                DIVM.AVM._activeAppointment.Arrived = false;
            }

        }



        private void OnMouseLeftRelease_Modify(object sender, MouseButtonEventArgs e)
        {
            Home h = App.Current.MainWindow as Home;
            h.SidebarView.SetSidebarView(new ModifyAppointmentSidebar());
        }



        private void OnMouseLeftRelease_Delete(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result =
                
                MessageBox.Show
                (
                    "Are you sure you wish to delete this appointment?",
                    "Confirm Selection",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Asterisk
                );

            if (result == MessageBoxResult.No || result == MessageBoxResult.None)
                return;


            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Appointment appt = DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)];

            // May need to call twice if the appt was a consultation.
            // Once for the appt that was following it and once the appt itself.
            DIVM.FreeAppointmentSlot(appt);


            if (DIVM.AVM._activeAppointment.Type == "Consultation")
            {
                Appointment apptThatFollows = DIVM.AVM.FindAppointmentThatFollows(appt);
                DIVM.AVM._appointmentLookup[Int32.Parse(apptThatFollows.ID)].Visibility = "Visible";

                // Set the appointment slot that was holding the consultation back to a 15 minute empty place holder
                appt.EndTime -= 15;

                if (appt.EndTime % 100 > 60)
                    appt.EndTime -= 40;
           }


            appt.Comments = "";
            appt.Height = "35";
            appt.Margin = "0,1,0,0";
            appt.Missed = false;
            appt.Arrived = false;
            appt.Opacity = "0";
            appt.Patient = "";
            appt.Type = "";
            appt.Waitlisted = false;

            if (appt.PatientObj != null)
                appt.PatientObj.RemoveUpcommingAppointmentKey(Int32.Parse(appt.ID));

            Home h = (App.Current.MainWindow as Home);
            h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
        }

        private void SaveNotesBtn_Click(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)].Comments = CommentBox.Text;
        }
    }
}
