
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
using Appointed.Classes;
using Appointed.ViewModels;

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NewAppointmentSidebar : UserControl
    {
        public NewAppointmentSidebar()
        {
            InitializeComponent();
           
            Home h = App.Current.MainWindow as Home;

            Button backButton = new Button
            {
                Content = new Image()
                {
                    Source = Assets.ResourceManager.Instance.Images["ReturnIcon"],
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };

            Button homeButton = new Button
            {
                Content = new Image()
                {
                    Source = Assets.ResourceManager.Instance.Images["HomeIcon"],
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };


            h.SidebarView.SetLeftQuickNavButton(backButton);
            h.SidebarView.SetRightQuickNavButton(homeButton);
        }

        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            Home h = App.Current.MainWindow as Home;

            h.SidebarView.SetSidebarView(new SearchResultsSidebar());
        }

        private void ComboBox_TimeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StartTime.SelectedItem == null)
            {
                return;
            }

            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToShortTimeString();
            }
        }

        private void OnMouseLeftRelease_Save(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            //don't think I need active appointment, will make when done gettting values from boxes
            Appointment targetAppointment = null;
            Appointment apptThatFollowsTarget = null;

            string stTime = ((Time)StartTime.SelectedItem).TimeString;
            string timeCmp = stTime;
            stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);

            string endTime = EndTime.Text;
            endTime = endTime.Substring(0, endTime.IndexOf(':')) + endTime.Substring(endTime.IndexOf(':') + 1, 2);

            string type = ApptTypeComboBox.SelectedValue.ToString();
            type = type.Substring(type.LastIndexOf(':') + 2); //ask what this does

            string drName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            string dateString = DatePicker.InputText.TextField.Text;

            // Build the key to look up the appointment slot they wish to book in.
            int time = Int32.Parse(stTime);
            int year = Int32.Parse(dateString.Substring(0, dateString.IndexOf('-')));

            int firstInd = dateString.IndexOf('-') + 1;
            int secondInd = dateString.LastIndexOf('-');
            int month = Int32.Parse(dateString.Substring(firstInd, secondInd - firstInd));

            int day = Int32.Parse(dateString.Substring(dateString.LastIndexOf('-') + 1));

            // The hashcode of the DateTime + <DrColumn> form the key for appointment lookups.
            DateTime dt = new DateTime(year, month, day, time / 100, time % 100, 0);
            int drColumn = DIVM.AVM.FindDrColumnForDrName(drName);
            int key = dt.GetHashCode() + drColumn;

            targetAppointment = DIVM.AVM._appointmentLookup[key];
            if (targetAppointment != null)
            {
                if (type == "Consultation")
                    apptThatFollowsTarget = DIVM.AVM.FindAppointmentThatFollows(targetAppointment);

                if ((targetAppointment.Type != "") || (type == "Consultation" && apptThatFollowsTarget.Type != ""))
                {
                    MessageBox.Show(
                        "The Time Slot Specified Is Taken!",
                        "Unable to Modify Appointment",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);

                    return;
                }

                if ((!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(Int32.Parse(stTime))) ||
                        (!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(Int32.Parse(endTime))))
                {
                    MessageBox.Show(
                        "The Doctor Specified Is Unavaliable At That Time!",
                        "Unable to Modify Appointment",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);

                    return;
                }


            }

            DIVM._activeDate.HasChanged = false;
        }

        //Appointment _newAppointment = new Appointment();
        //Now need to figure out the way to create a new appointment, store the values into it

       


       
        

    }

}
