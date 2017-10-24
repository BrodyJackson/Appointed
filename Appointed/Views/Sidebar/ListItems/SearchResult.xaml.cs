using Appointed.ViewModels;
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

namespace Appointed.Views.Sidebar.ListItems
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : UserControl
    {
        private Patient patient;
        public Patient Patient
        {
            get => patient;
            set
            {
                patient = value;
                PatientName.Text = patient.LastName + ", " + patient.FirstName + " " + patient.MiddleName[0] + ".";
                PatientID.Text = patient.GetHealthIdAsString();
                PatientSex.Text = "Sex: " + patient.GetSexAsString();
                PatientBirthday.Text = "Birthdate: " + patient.BirthDate.ToShortDateString();
            }
        }


        public SearchResult(Patient p)
        {
            InitializeComponent();

            Patient = p;
        }

        
    }
}
