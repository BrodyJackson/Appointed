using Appointed.ViewModels;
using Appointed.Views.Sidebar;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows.Input;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for HomeTabView.xaml
    /// </summary>
    public partial class HomeSidebar : UserControl
    {

        public HomeSidebar()
        {
            InitializeComponent();

            SearchInput.Search += SearchInput_Search;

            //AlertBox.AddAlert(new Classes.Alert() { ButtonText = "Reschedule", Title = "Appt. Bump Available for Mike Ross" });
            //AlertBox.AddAlert(new Classes.Alert() { ButtonText = "Reschedule", Title = "Jerry Sienfeld Missed Appointment" });
            //AlertBox.AddAlert(new Classes.Alert() { ButtonText = "Reschedule", Title = "Arnold P. Jenkins Missed Appointment" });

            //AlertBox.UpdateAlertsBox();

            JumpCalendar.Calendar.SelectedDatesChanged += Calendar_SelectedDatesChanged;
            JumpCalendar.Today_Btn.Click += TodayButton_MouseRelease;

            Loaded += HomeSidebar_Loaded;
        }


        //Gross work-around for going back to home sidebar from search results
        private void HomeSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            SearchInput.InputField.TextField.Text = "";
            SearchInput.InputField.ShowHintText(SearchInput.InputField.TextField);
        }

        private void SearchInput_Search(object sender, System.EventArgs e)
        {
            Home home = App.Current.MainWindow as Home;

            home.SidebarView.SetSidebarView(new SearchResultsSidebar(SearchInput.InputField.TextField.Text));
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (JumpCalendar.Calendar.SelectedDate.HasValue) //Catch setting date to null and don't change anything
            {
                DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

                DateTime activeDT = new DateTime(DIVM._activeDate.Year, DIVM._activeDate.Month, DIVM._activeDate.Day);

                //DateTime selectedDT = (sender as Calendar).SelectedDate.Value;

                TimeSpan diff = (sender as Calendar).SelectedDate.Value - activeDT;

                ShiftScheduleView(diff.Days - 1);

                //Clear selection so this event will fire for the same day twice in a row
                JumpCalendar.Calendar.SelectedDate = null;
            }
            else
            {
                //Handle event so that no other listeners attempt to do something with a null date
                e.Handled = true;
            }
        }


        private void TodayButton_MouseRelease(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            DateTime activeDT = new DateTime(DIVM._activeDate.Year, DIVM._activeDate.Month, DIVM._activeDate.Day);

            DateTime selectedDT = DateTime.Today;

            TimeSpan diff = selectedDT - activeDT;

            ShiftScheduleView(diff.Days - 1);
        }


        void ShiftScheduleView(int amount)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            if (DIVM.ShiftView.CanExecute(null))
                DIVM.ShiftView.Execute(amount);
        }


    }
}
