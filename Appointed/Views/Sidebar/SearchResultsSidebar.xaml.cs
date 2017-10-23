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

        public SearchResultsSidebar()
        {
            InitializeComponent();

            _resultPatients = new List<Patient>();

            AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = 1 });
            AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = 1 });
            AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = 1 });

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
            //TODO: Create New Patient result
            //SearchResultsList.Children.Add(new CreateNewPatientSearchResult());


            foreach(Patient p in _resultPatients)
            {
                SearchResultsList.Children.Add(new SearchResult(p));
            }
        }

    }
}
