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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Appointed.Views;
using Appointed.Views.Sidebar;
using Appointed.Views.Dialogs;
using Appointed.ViewModels;
using Appointed.Classes;
using System.Collections.ObjectModel;

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
            ShowHomeSidebar();

            this.Loaded += new RoutedEventHandler(HomeView_Loaded);
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
                    DIVM.AVM.DoctorsOnShift[drColumn].Visibility  = "Collapsed";
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


    }
}
