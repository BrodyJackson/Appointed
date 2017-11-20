using Appointed.Classes;
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

            AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1964, 1, 3), HealthID = 65874515, Sex = Patient.SEX.MALE });
            AddPatient(new Patient() { FirstName = "Benjamin", MiddleName = "Thomas", LastName = "Gargonzola", BirthDate = new DateTime(1996, 4, 23), HealthID = 78541203, Sex = Patient.SEX.MALE });
            AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Larry", LastName = "Knuth", BirthDate = new DateTime(1996, 12, 30), HealthID = 47130200, Sex = Patient.SEX.OTHER });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.MALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.FEMALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 12, 30), HealthID = 55555555, Sex = Patient.SEX.OTHER });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.MALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.FEMALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 12, 30), HealthID = 55555555, Sex = Patient.SEX.OTHER });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.MALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.FEMALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 12, 30), HealthID = 55555555, Sex = Patient.SEX.OTHER });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.MALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.FEMALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 12, 30), HealthID = 55555555, Sex = Patient.SEX.OTHER });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.MALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 1, 3), HealthID = 55555555, Sex = Patient.SEX.FEMALE });
            //AddPatient(new Patient() { FirstName = "Ben", MiddleName = "Jay", LastName = "Tester", BirthDate = new DateTime(1996, 12, 30), HealthID = 55555555, Sex = Patient.SEX.OTHER });

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

            SearchResultsList.Children.Add(new CreateNewPatientResultItem(_resultPatients.Count > 0 ? "Can't Find Patient?" : "No Patients Found"));
        }

    }
}
