using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Classes;

namespace Appointed.Models
{
    class PatientDatabaseModel
    {

        // The patient's health care ID is the key to the Patient Object.
        private Dictionary<int, Patient> _patientDictionary;



        // Shouldn't need these functions. They are used by the ViewModel
        // allowing the view logic to be spearated from the logic of the data class.
        // See PatientViewModel for add/get/remove functions.
        public bool PutPatient(Patient p)
        {
            if (_patientDictionary.ContainsKey(p.HealthID))
                return false;

            _patientDictionary[p.HealthID] = p;

            return true;
        }

        public bool RemovePatient(Patient p)
        {
            if (!_patientDictionary.ContainsKey(p.HealthID))
                return false;

            _patientDictionary.Remove(p.HealthID);

            return true;
        }


        public Patient GetPatient(int key)
        {
            return _patientDictionary[key];
        }

        /// <summary>
        /// This method allows for searching of dictionary items if key is not known
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Patient> GetPatientDictionary()
        {
            return _patientDictionary;
        }

        


        public PatientDatabaseModel()
        {
            // instantiate the dictionary.
            _patientDictionary = new Dictionary<int, Patient>();

            // One fake emergency contact.
            EmergencyContact e = new EmergencyContact
            { EmergencyName="Don Ling Juan", EmergencyPhone="567-890-1234", EmergencyRelation=EmergencyContact.RELATION.SIBLING };

            // One fake patient corresponding to Mike Ross.
            _patientDictionary[12345678] = new Patient
            {
                FirstName = "Mike",
                MiddleName = "Jean",
                LastName = "Ross",
                HealthID = 12345678,
                BirthDate = new DateTime(1990, 12, 5),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-333",
                Street ="23 Ave",
                Building ="182",
                Suite ="12",
                Phone = "555-555-5555",
                Cell = "403-555-5655",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345679] = new Patient
            {

            };

            _patientDictionary[12345680] = new Patient
            {

            };

            _patientDictionary[12345681] = new Patient
            {

            };

            _patientDictionary[12345682] = new Patient
            {

            };

            _patientDictionary[12345683] = new Patient
            {

            };

            _patientDictionary[12345684] = new Patient
            {

            };

            _patientDictionary[12345685] = new Patient
            {
                
            };

            _patientDictionary[12345686] = new Patient
            {

            };

            _patientDictionary[12345687] = new Patient
            {

            };

            _patientDictionary[12345688] = new Patient
            {

            };

            _patientDictionary[12345689] = new Patient
            {

            };

            _patientDictionary[12345690] = new Patient
            {

            };

            _patientDictionary[12345691] = new Patient
            {

            };

            _patientDictionary[12345692] = new Patient
            {

            };


        }




    }
}
