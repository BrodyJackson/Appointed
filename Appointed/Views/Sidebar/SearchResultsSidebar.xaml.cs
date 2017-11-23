using Appointed.Classes;
using Appointed.Models;
using Appointed.ViewModels;
using Appointed.Views.Sidebar.ListItems;
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

namespace Appointed.Views.Sidebar
{

    /// <summary>
    /// Interaction logic for SearchResultsSidebar.xaml
    /// </summary>
    public partial class SearchResultsSidebar : UserControl
    {
        private List<Patient> _resultPatients;

        private string _searchTerm;

        public SearchResultsSidebar(string searchTerm)
        {
            InitializeComponent();

            _resultPatients = new List<Patient>();

            SearchBar.InputField.TextField.Text = searchTerm;

            _searchTerm = searchTerm;

            Search(searchTerm);

            SearchBar.Search += SearchBar_Search;
        }

        private void SearchBar_Search(object sender, EventArgs e)
        {
            _resultPatients.Clear();

            _searchTerm = SearchBar.InputField.TextField.Text;

            Search(_searchTerm);
        }

        public SearchResultsSidebar()
        {
            InitializeComponent();

            _resultPatients = new List<Patient>();
        }

        public void Search(string searchTerm)
        {
            DayInformationViewModel divm = App.Current.MainWindow.DataContext as DayInformationViewModel;

            //Sanitize input
            searchTerm = new String(searchTerm.Where(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)).ToArray()).ToLower();

            //Only search if searchTerm exists
            if (!String.IsNullOrWhiteSpace(searchTerm))
            {
                string[] searchTerms = searchTerm.Split(' ');

                Dictionary<int, Patient> patientDict = divm.PVM.GetPatientDatabaseModel().GetPatientDictionary();

                foreach (KeyValuePair<int, Patient> entry in patientDict)
                {
                    //Check for match or partial match of 
                    if (entry.Key.ToString().Contains(searchTerm))
                    {
                        _resultPatients.Add(entry.Value);
                    }
                    else
                    {
                        foreach (string term in searchTerms)
                        {
                            if (!String.IsNullOrWhiteSpace(term))
                            {
                                //Check for a match to first name
                                if (!String.IsNullOrEmpty(entry.Value.FirstName) && entry.Value.FirstName.ToLower().Contains(term))
                                {
                                    _resultPatients.Add(entry.Value);
                                    break;
                                }

                                //Check for last name match
                                if (!String.IsNullOrEmpty(entry.Value.LastName) && entry.Value.LastName.ToLower().Contains(term))
                                {
                                    _resultPatients.Add(entry.Value);
                                    break;
                                }

                                //Check middle name match
                                if (!String.IsNullOrEmpty(entry.Value.MiddleName) && entry.Value.MiddleName.ToLower().Contains(term))
                                {
                                    _resultPatients.Add(entry.Value);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            UpdatePatientResultList();
        }

        public void AddPatient(Patient patient)
        {
            _resultPatients.Add(patient);

        }

        public void RemovePatient(Patient patient)
        {
            _resultPatients.Remove(patient);
        }

        public void UpdatePatientResultList()
        {
            SearchResultsList.Children.Clear();

            //Sort by last name, then first name, then middle name, then healthid
            _resultPatients = _resultPatients.OrderBy(x => x.LastName + x.FirstName + x.MiddleName + x.HealthID).ToList();

            foreach (Patient p in _resultPatients)
            {
                SearchResultsList.Children.Add(new SearchResult(p));
            }

            CreateNewPatientResultItem newPatientItem = new CreateNewPatientResultItem(_resultPatients.Count > 0 ? "Can't Find Patient?" : "No Patients Found");

            newPatientItem.Action.Click +=
                (object sender, RoutedEventArgs e) =>
                {
                    Dialogs.NewPatientDialog newPatientDialog = new Dialogs.NewPatientDialog();
                    newPatientDialog.ShowDi
alog();

                    switch (newPatientDialog.ExitAction)
                    {
                        case Dialogs.NewPatientDialog.EXIT_ACTION.SAVE:
                            _resultPatients.Clear();
                            Search(_searchTerm);
                            break;
                        case Dialogs.NewPatientDialog.EXIT_ACTION.SAVEBOOK:
                            break;
                        case Dialogs.NewPatientDialog.EXIT_ACTION.DISCARD:
                            break;
                        default:
                            break;
                    }

                };

            SearchResultsList.Children.Add(newPatientItem);
        }

    }
}
