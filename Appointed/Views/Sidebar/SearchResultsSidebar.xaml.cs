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
            //TODO: Search Patient Database
            //TODO: Get Results, then Add them to _resultPatients

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

            foreach(Patient p in _resultPatients)
            {
                SearchResultsList.Children.Add(new SearchResult(p));
            }

            CreateNewPatientResultItem newPatientItem = new CreateNewPatientResultItem(_resultPatients.Count > 0 ? "Can't Find Patient?" : "No Patients Found");

            newPatientItem.Action.Click += 
                (object sender, RoutedEventArgs e) => 
                {
                    Dialogs.NewPatientDialog newPatientDialog = new Dialogs.NewPatientDialog();

                    newPatientDialog.ShowDialog();

                    //Re-Search the patients
                    if (newPatientDialog.ExitAction == Dialogs.NewPatientDialog.EXIT_ACTION.SAVE)
                    {
                        Search(_searchTerm);
                    }
                };

            SearchResultsList.Children.Add(newPatientItem);
        }

    }
}
