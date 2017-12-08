using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Classes;


namespace Appointed.Models
{
    public class PatientDatabaseModel
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
            { EmergencyName="Don Ling Juan", EmergencyPhone="(567) 890-1234", EmergencyRelation="Brother" };

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
                PostalCode = "T3A-3H3",
                Street ="23 Ave",
                Phone = "(555) 555-5556",
                Cell = "(403) 555-5055",
                Email = "RagnaarLothbrock@neopets.com",
                EmergencyContact = e
            };

            _patientDictionary[12345679] = new Patient
            {
                FirstName="Mikala",
                MiddleName = "Joan",
                LastName = "Ross",
                HealthID = 12345679,
                BirthDate = new DateTime(1996, 12, 5),
                Sex = Patient.SEX.FEMALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T2T-3S6",
                Street = "23 Ave",
                Phone = "(555) 555-5557",
                Cell = "(403) 555-5155",
                Email = "obiWan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[86753090] = new Patient
            {
                FirstName = "Mike",
                MiddleName = "Jean",
                LastName = "Ross",
                HealthID = 86753090,
                BirthDate = new DateTime(1983, 01, 17),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "H5H-4H4",
                Street = "23 Ave",
                Phone = "(555) 555-5558",
                Cell = "(403) 555-5255",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345680] = new Patient
            {
                FirstName = "Freddison",
                MiddleName = "",
                LastName = "Junior",
                HealthID = 12345680,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "TsuuTina",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3B3",
                Street = "Grey Eagle St",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-5355",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345681] = new Patient
            {
                FirstName = "Brody",
                MiddleName = "",
                LastName = "Jackson",
                HealthID = 12345681,
                BirthDate = new DateTime(1993, 05, 16),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3C3",
                Street = "Chapparel",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-5455",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345682] = new Patient
            {
                FirstName = "Brody",
                MiddleName = "Jackson's",
                LastName = "Aunty",
                HealthID = 12345682,
                BirthDate = new DateTime(1980, 12, 21),
                Sex = Patient.SEX.FEMALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3D3",
                Street = "Dover Street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-5555",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345683] = new Patient
            {
                FirstName = "Fred",
                MiddleName = "",
                LastName = "Junior",
                HealthID = 12345682,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3E3",
                Street = "Fred Street",
                Phone = "(555) 403-4034",
                Cell = "(403) 555-5655",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345684] = new Patient
            {
                FirstName = "Orville",
                MiddleName = "",
                LastName = "Reddenschtapper",
                HealthID = 12345684,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3F3",
                Street = "A street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-5755",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345685] = new Patient
            {
                FirstName = "Francis",
                MiddleName = "",
                LastName = "Francois",
                HealthID = 12345685,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3G3",
                Street = "B street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-5855",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345686] = new Patient
            {
                FirstName = "Tim",
                MiddleName = "",
                LastName = "Horton",
                HealthID = 12345686,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3I3",
                Street = "C street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-5955",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345687] = new Patient
            {
                FirstName = "George",
                MiddleName = "",
                LastName = "Martin",
                HealthID = 12345687,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3J3",
                Street = "D street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6055",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345688] = new Patient
            {
                FirstName = "Trick",
                MiddleName = "",
                LastName = "Thomas",
                HealthID = 12345688,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3K3",
                Street = "E street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6155",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345689] = new Patient
            {
                FirstName = "Mary",
                MiddleName = "",
                LastName = "Ross",
                HealthID = 12345689,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.FEMALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3L3",
                Street = "F street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6255",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345690] = new Patient
            {
                FirstName = "Tappity",
                MiddleName = "",
                LastName = "Thomas",
                HealthID = 12345690,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3M3",
                Street = "G street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6355",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345691] = new Patient
            {
                FirstName = "Brandon",
                MiddleName = "",
                LastName = "Slack",
                HealthID = 12345691,
                BirthDate = new DateTime(1990, 03, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3N3",
                Street = "H street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6455",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };

            _patientDictionary[12345692] = new Patient
            {
                FirstName = "Ned",
                MiddleName = "",
                LastName = "Stark",
                HealthID = 12345692,
                BirthDate = new DateTime(1990, 05, 01),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3O3",
                Street = "J street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6655",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345693] = new Patient
            {
                FirstName = "Ichiban",
                MiddleName = "",
                LastName = "Foresupper",
                HealthID = 12345693,
                BirthDate = new DateTime(1990, 05, 02),
                Sex = Patient.SEX.FEMALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3P3",
                Street = "K street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6755",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };



            _patientDictionary[12345694] = new Patient
            {
                FirstName = "Cornell",
                MiddleName = "",
                LastName = "Smith",
                HealthID = 12345694,
                BirthDate = new DateTime(1990, 05, 03),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3Q3",
                Street = "L street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6855",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345695] = new Patient
            {
                FirstName = "Marylin",
                MiddleName = "",
                LastName = "Ross",
                HealthID = 12345695,
                BirthDate = new DateTime(1990, 05, 04),
                Sex = Patient.SEX.FEMALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3R3",
                Street = "M street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-6955",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345696] = new Patient
            {
                FirstName = "Mr.",
                MiddleName = "No",
                LastName = "Chill",
                HealthID = 12345696,
                BirthDate = new DateTime(1990, 05, 05),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3S3",
                Street = "N street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7055",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345697] = new Patient
            {
                FirstName = "Marc",
                MiddleName = "",
                LastName = "Ross",
                HealthID = 12345697,
                BirthDate = new DateTime(1990, 05, 06),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3T3",
                Street = "O street",
                Phone = "(555) 696-7169",
                Cell = "(403) 555-6555",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345698] = new Patient
            {
                FirstName = "Molly",
                MiddleName = "",
                LastName = "Ross",
                HealthID = 12345698,
                BirthDate = new DateTime(1990, 05, 07),
                Sex = Patient.SEX.FEMALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3U3",
                Street = "P street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7255",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345699] = new Patient
            {
                FirstName = "James",
                MiddleName = "",
                LastName = "Dean",
                HealthID = 12345699,
                BirthDate = new DateTime(1990, 05, 08),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3V3",
                Street = "Q street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7355",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345700] = new Patient
            {
                FirstName = "Jeremy",
                MiddleName = "",
                LastName = "Pumpkinspice",
                HealthID = 12345700,
                BirthDate = new DateTime(1990, 05, 09),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3W3",
                Street = "R street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7455",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345701] = new Patient
            {
                FirstName = "Odor",
                MiddleName = "",
                LastName = "Onus",
                HealthID = 12345701,
                BirthDate = new DateTime(1990, 05, 10),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3X3",
                Street = "S street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7555",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345702] = new Patient
            {
                FirstName = "Mr.",
                MiddleName = "",
                LastName = "Voldemort",
                HealthID = 12345702,
                BirthDate = new DateTime(1990, 05, 11),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3Y3",
                Street = "T street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7655",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345792] = new Patient
            {
                FirstName = "Denaerys",
                MiddleName = "",
                LastName = "Targarian",
                HealthID = 12345792,
                BirthDate = new DateTime(1990, 05, 12),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "T3A-3Z3",
                Street = "U street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7755",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[12345892] = new Patient
            {
                FirstName = "Jon",
                MiddleName = "",
                LastName = "Snow",
                HealthID = 12345892,
                BirthDate = new DateTime(1990, 05, 13),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "U3A-3O3",
                Street = "V street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-7855",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[22345692] = new Patient
            {
                FirstName = "Harry",
                MiddleName = "",
                LastName = "Potter",
                HealthID = 22345692,
                BirthDate = new DateTime(1990, 05, 14),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "V3A-3O3",
                Street = "W street",
                Phone = "(555) 696-7969",
                Cell = "(403) 555-6555",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[32345692] = new Patient
            {
                FirstName = "Jonathan",
                MiddleName = "",
                LastName = "Shabash",
                HealthID = 32345692,
                BirthDate = new DateTime(1990, 05, 15),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "W3A-3O3",
                Street = "X street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-8055",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[42345692] = new Patient
            {
                FirstName = "Dabin",
                MiddleName = "",
                LastName = "Lamming",
                HealthID = 42345692,
                BirthDate = new DateTime(1990, 05, 16),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "X3A-3O3",
                Street = "Y street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-8155",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };




            _patientDictionary[52345692] = new Patient
            {
                FirstName = "Frodo",
                MiddleName = "",
                LastName = "Baggins",
                HealthID = 52345692,
                BirthDate = new DateTime(1990, 05, 17),
                Sex = Patient.SEX.MALE,
                City = "Calgary",
                Province = Patient.PROVINCE.AB,
                PostalCode = "Y3A-3O3",
                Street = "Z street",
                Phone = "(555) 696-6969",
                Cell = "(403) 555-8255",
                Email = "DonJuan@donjuan.com",
                EmergencyContact = e
            };



        }




    }
}
