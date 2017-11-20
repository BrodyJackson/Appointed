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
        public bool putPatient(Patient p)
        {
            if (_patientDictionary.ContainsKey(p.HealthID))
                return false;

            _patientDictionary[p.HealthID] = p;

            return true;
        }

        public bool removePatient(Patient p)
        {
            if (!_patientDictionary.ContainsKey(p.HealthID))
                return false;

            _patientDictionary.Remove(p.HealthID);

            return true;
        }


        public Patient getPatient(int key)
        {
            return _patientDictionary[key];
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
                BirthDate=new DateTime(1990, 12, 5), Cell="403-555-5655", City="Calgary", Email="DonJuan@donjuan.com",
                EmergencyContact=e, FirstName="Mike", HealthID=12345678, LastName="Ross",
                MiddleName ="Jean", Phone="555-555-5555", PostalCode="T3A-333", Province=Patient.PROVINCE.AB,
                Sex =Patient.SEX.MALE, Street="23 Ave", Building="182", Suite="12"
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
