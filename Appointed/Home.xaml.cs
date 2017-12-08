using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Appointed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();

            EventManager.RegisterClassHandler
            (
                typeof(Window),
                Keyboard.KeyUpEvent,
                new KeyEventHandler(Key_Up), true
            );

            ShowHomeSidebar();

            this.Loaded += new RoutedEventHandler(HomeView_Loaded);
        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                //MessageBox.Show("Delete Up!");
            }
            else if (e.Key == Key.Left)
            {
                if (App.AllowArrowKeyCalendarNavigation) //So when in input text arrow keys dont move scheduel
                {
                    if (Keyboard.IsKeyDown(Key.LeftShift))
                        ShiftScheduleView(-7);
                    else if (Keyboard.IsKeyDown(Key.LeftCtrl))
                        ShiftScheduleView(-3);
                    else
                        ShiftScheduleView(-1);
                }
            }
            else if (e.Key == Key.Right)
            {
                if (App.AllowArrowKeyCalendarNavigation) //So when in input text arrow keys dont move scheduel
                {
                    if (Keyboard.IsKeyDown(Key.LeftShift))
                        ShiftScheduleView(7);
                    else if (Keyboard.IsKeyDown(Key.LeftCtrl))
                        ShiftScheduleView(3);
                    else
                        ShiftScheduleView(1);
                }
            }
            //else if (e.Key == Key.LeftShift)
            //{
            //    ShiftScheduleView(-7);
            //}
            //else if (e.Key == Key.RightShift)
            //{
            //    ShiftScheduleView(7);
            //}
            else if (e.Key == Key.Up)
            {
            }
            else if (e.Key == Key.Down)
            {

            }
            else if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                //MessageBox.Show("Enter or Return Up!");
            }
        }

        void ShiftScheduleView(int amount)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            if (DIVM.ShiftView.CanExecute(null))
                DIVM.ShiftView.Execute(amount);
        }

        private void ShowHomeSidebar()
        {
            HomeSidebar homeSidebar = new HomeSidebar();

            SidebarView.SetSidebarView(homeSidebar);
        }

        void HomeView_Loaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            DIVM.ApptFilterChangedDIVM += new EventHandler<EventArgs>(OnApptFilterChanged);
            DIVM.DoctorFilterChangedDIVM += new EventHandler<EventArgs>(OnDocFilterChanged);
        }

        void OnApptFilterChanged(Object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            foreach (KeyValuePair<string, bool> filter in App.CalendarApptFilter)
            {
                string type = filter.Key;

                if (filter.Value)
                {
                    foreach (KeyValuePair<int, Appointment> appt in DIVM.AVM._appointmentLookup)
                        if (appt.Value.Type == type)
                            appt.Value.Visibility = "Visible";
                }
                else
                {
                    foreach (KeyValuePair<int, Appointment> appt in DIVM.AVM._appointmentLookup)
                        if (appt.Value.Type == type)
                            appt.Value.Visibility = "Hidden";
                }
            }
        }

        void OnDocFilterChanged(Object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;
            int drColumn;

            foreach (KeyValuePair<string, bool> filter in App.CalendarDocFilter.ToList())
            {
                string name = "Dr. " + filter.Key;
                drColumn = DIVM.AVM.FindDrColumnForDrName(name);

                if (!filter.Value)
                {
                    DIVM.AVM.DoctorsOnShift[drColumn].Visibility = "Collapsed";
                    DIVM.AVM.DoctorsOnShift[drColumn].ColumnWidth = "0";

                    ObservableCollection<Doctor> visibleDoctors = new ObservableCollection<Doctor>();
                    foreach (Doctor d in DIVM.AVM.DoctorsOnShift)
                        if (d.Visibility == "Visible")
                            visibleDoctors.Add(d);

                    DIVM.AVM.DoctorsOnShiftFiltered = visibleDoctors;
                }
                else
                {
                    DIVM.AVM.DoctorsOnShift[drColumn].Visibility = "Visible";
                    DIVM.AVM.DoctorsOnShift[drColumn].ColumnWidth = "*";

                    ObservableCollection<Doctor> visibleDoctors = new ObservableCollection<Doctor>();
                    foreach (Doctor d in DIVM.AVM.DoctorsOnShift)
                        if (d.Visibility == "Visible")
                            visibleDoctors.Add(d);

                    DIVM.AVM.DoctorsOnShiftFiltered = visibleDoctors;
                }
            }
        }

        private void OnMouseDownWindow(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            DIVM.AVM._activeAppointment.Colour = DIVM.AVM.FindDrColourForDrName(DIVM.AVM._activeAppointment.DoctorName);
            DIVM.AVM._activeAppointment.Opacity = "0.5";
        }
    }
}
