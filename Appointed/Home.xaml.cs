using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Appointed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Home : Window
    {
        int randomKey;

        public Home()
        {
            InitializeComponent();

            EventManager.RegisterClassHandler
            (
                typeof(Window),
                Keyboard.KeyUpEvent,
                new KeyEventHandler(Key_Up), true
            );

            DispatcherTimer d = new DispatcherTimer(new TimeSpan(0, 0, 15), DispatcherPriority.Normal, OnTimeInterval, this.Dispatcher);

            ShowHomeSidebar();

            this.Loaded += new RoutedEventHandler(HomeView_Loaded);

            randomKey = 0;
        }

        private void OnTimeInterval(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            if (randomKey != 0)
            {
                DIVM.AVM._appointmentLookup[randomKey].Colour = DIVM.AVM.FindDrColourForDrName(DIVM.AVM._appointmentLookup[randomKey].DoctorName);
                DIVM.AVM._appointmentLookup[randomKey].Opacity = DIVM.AVM._appointmentLookup[randomKey].Type == "" ? "0.0" : "0.5";
            }

            Random r = new Random();
            int num = r.Next(21);                           // Less than 21 + 6 keeps it in top portion of view

            num += 6;                                       // Avoid grayed out appts
            num = ((num / 4) * 100) + ((num % 4) * 15);     // num / 4 is num hrs to skip, slots % 4 is num 15 minute intervals
            num += 700;                                     // Days start at 700

            int num2 = r.Next(1,4);                         // Random Dr. Column

            DateTime dt = new DateTime(DIVM.YearAsInt, DIVM.MonthAsInt, DIVM.DayAsInt, num/100, num%100, 0);

            int key = dt.GetHashCode() + num2;

            if (DIVM.AVM._appointmentLookup.ContainsKey(key))
            {
                DIVM.AVM._appointmentLookup[key].Colour = "Purple";
                DIVM.AVM._appointmentLookup[key].Opacity = "1.0";

                randomKey = key;
            }
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
