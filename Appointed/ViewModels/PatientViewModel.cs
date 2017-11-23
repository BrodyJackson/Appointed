using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;
using Appointed.Models;
using Appointed.Classes;

namespace Appointed.ViewModels
{
    public class PatientViewModel : ObservableObject
    {
        private PatientDatabaseModel patientDatabaseModel;

        public PatientDatabaseModel GetPatientDatabaseModel()
        {
            return patientDatabaseModel;
        }

        public void SetPatientDatabaseModel(PatientDatabaseModel value)
        {
            patientDatabaseModel = value;
        }

        private Patient _activePatient;


        public PatientViewModel()
        {
            _activePatient = new Patient();
            SetPatientDatabaseModel(new PatientDatabaseModel());
        }



        // Use these functions to update the view Model.
        // There is an instance of a PatientViewModel in the DayInformationViewModel
        // so you don't need to instantiate one of these. Just do
        // using Appointed.ViewModels; -- at the top ^
        // DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
        // DIVM.PVM.addPatient(p);
        public bool AddPatient(Patient p)
        {
            return GetPatientDatabaseModel().PutPatient(p);
        }

        public bool RemovePatient(Patient p)
        {
            return GetPatientDatabaseModel().RemovePatient(p);
        }


        public Patient GetPatient(int HealthCareID)
        {
            return GetPatientDatabaseModel().GetPatient(HealthCareID);
        }


        public Patient ActivePatient
        {
            get { return _activePatient; }
            set
            {
                _activePatient = value;
                RaisePropertyChangedEvent("ActivePatient");
            }
        }


    }
}
