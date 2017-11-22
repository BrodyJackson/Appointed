using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Appointed.ViewModels;
using Appointed.Classes;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for FilterView.xaml
    /// </summary>
    public partial class FilterView : UserControl
    {
        private Dictionary<string, CheckBox> _filterNameToCheckbox = new Dictionary<string, CheckBox>();
        private Dictionary<CheckBox, string> _checkboxToFilterName = new Dictionary<CheckBox, string>();
        private bool _isAllDocsSelected;
        private bool _isAllApptsSelected;

        //Events raised when their respective filter classes are changed.
        // If needed, create new event args class to pass needed data
        
        /// <summary>
        /// Invoked whenever a filter option is changed.
        /// When all or no doctors is clicked, this event will fire for each of the filter options that have changed.
        /// </summary>
        public event EventHandler<EventArgs> DoctorFilterChanged;
        /// <summary>
        /// Invoked whenever a filter option is changed.
        /// When all or no appts is clicked, this event will fire for each of the filter options that have changed.
        /// </summary>
        public event EventHandler<EventArgs> ApptFilterChanged;

        public FilterView()
        {
            InitializeComponent();

            //Bi-directional dictionary entries
            RegisterFilterOption("Pearson", PearsonCheckBox);
            RegisterFilterOption("Paulsen", PaulsenCheckBox);
            RegisterFilterOption("Specter", SpecterCheckBox);
            RegisterFilterOption("Standard", RegCheckBox);
            RegisterFilterOption("Consultation", ConsultCheckBox);

            //Set Visual filter checkboxes based on the global state
            UpdateDocFilters();
            UpdateApptFilters();

            //Adding event listeners
            AllDocBtn.Click += AllDocBtn_Click;
            AllApptsBtn.Click += AllApptsBtn_Click;

            PearsonCheckBox.Checked += DocFilter_Checked;
            PaulsenCheckBox.Checked += DocFilter_Checked;
            SpecterCheckBox.Checked += DocFilter_Checked;

            RegCheckBox.Checked += ApptFilter_Checked;
            ConsultCheckBox.Checked += ApptFilter_Checked;

            PearsonCheckBox.Unchecked += DocFilter_Unchecked;
            PaulsenCheckBox.Unchecked += DocFilter_Unchecked;
            SpecterCheckBox.Unchecked += DocFilter_Unchecked;

            RegCheckBox.Unchecked += AppFilter_Unchecked;
            ConsultCheckBox.Unchecked += AppFilter_Unchecked;


        }

        private void AppFilter_Unchecked(object sender, RoutedEventArgs e)
        {
            App.CalendarApptFilter[_checkboxToFilterName[sender as CheckBox]] = false;
            UpdateApptFilters();
            ApptFilterChanged?.Invoke(sender, EventArgs.Empty);
            (this.DataContext as DayInformationViewModel).changeAppointmentFilterSelection();
        }

        private void DocFilter_Unchecked(object sender, RoutedEventArgs e)
        {
            App.CalendarDocFilter[_checkboxToFilterName[sender as CheckBox]] = false;
            UpdateDocFilters();
            DoctorFilterChanged?.Invoke(sender, EventArgs.Empty);
            (this.DataContext as DayInformationViewModel).changeDoctorFilterSelection();
        }

        private void RegisterFilterOption(string name, CheckBox checkBox)
        {
            _filterNameToCheckbox.Add(name, checkBox);
            _checkboxToFilterName.Add(checkBox, name);
        }

        private void DocFilter_Checked(object sender, RoutedEventArgs e)
        {
            App.CalendarDocFilter[_checkboxToFilterName[sender as CheckBox]] = true;
            UpdateDocFilters();
            DoctorFilterChanged?.Invoke(sender, EventArgs.Empty);
            (this.DataContext as DayInformationViewModel).changeDoctorFilterSelection();
        }

        private void ApptFilter_Checked(object sender, RoutedEventArgs e)
        {
            App.CalendarApptFilter[_checkboxToFilterName[sender as CheckBox]] = true;
            UpdateApptFilters();
            ApptFilterChanged?.Invoke(sender, EventArgs.Empty);
            (this.DataContext as DayInformationViewModel).changeAppointmentFilterSelection();
        }

        private void AllApptsBtn_Click(object sender, RoutedEventArgs e)
        {
            ToggleAllApptFilter();
        }

        private void ToggleAllApptFilter()
        {
            foreach(string key in App.CalendarApptFilter.Keys.ToList())
            {
                App.CalendarApptFilter[key] = !_isAllApptsSelected;
            }

            UpdateApptFilters();
        }

        private void UpdateDocFilters()
        {
            //TODO: Update What is Shown in the Calendar View
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            foreach (KeyValuePair<string, bool> filter in App.CalendarDocFilter.ToList())
            {
                _filterNameToCheckbox[filter.Key].IsChecked = filter.Value;
            }

            if (App.CalendarDocFilter.Values.All(x => x == true))
            {
                AllDocBtn.Content = "No Doctors";
                _isAllDocsSelected = true;
            }
            else
            {
                AllDocBtn.Content = "All Doctors";
                _isAllDocsSelected = false;
            }
        }

        private void UpdateApptFilters()
        {
            //TODO: Update What is Shown in the Calendar View

            foreach (KeyValuePair<string, bool> filter in App.CalendarApptFilter.ToList())
            {
                _filterNameToCheckbox[filter.Key].IsChecked = filter.Value;
            }

            if (App.CalendarApptFilter.Values.All(x => x == true))
            {
                AllApptsBtn.Content = "No Appointments";
                _isAllApptsSelected = true;
            }
            else
            {
                AllApptsBtn.Content = "All Appointments";
                _isAllApptsSelected = false;
            }
        }


        private void AllDocBtn_Click(object sender, RoutedEventArgs e)
        {
            ToggleAllDoctorFilter();
        }

        private void ToggleAllDoctorFilter()
        {
            //Loop set filter values
            foreach(string key in App.CalendarDocFilter.Keys.ToList())
            {
                App.CalendarDocFilter[key] = !_isAllDocsSelected;
            }
            //update view
            UpdateDocFilters();
        }
    }
}
