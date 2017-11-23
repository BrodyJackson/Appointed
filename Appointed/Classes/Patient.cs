using System;
using Appointed.Events;
using Appointed.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.Classes
{

	public class Patient : ObservableObject
	{
		//Constant values

		//Sex
		public enum SEX { MALE, FEMALE, OTHER};

        //Provinces (and territories)
        public enum PROVINCE { AB, BC, MB, NB, NL, NT, NS, NU, ON, PE, QC, SK, YT};

		//General info
		string _firstName;
		string _middleName;
		string _lastName;
		DateTime _birthDate;
		SEX _sex;              
		int _healthID;

        //Address
        string _street;
        string _city;
		PROVINCE _province;        
		string _postalCode;


        //Contact
        string _business;
		string _phone;
		string _cell;
		string _email;

		//Emergency Contact
		EmergencyContact _emergencyContact;

        //Notes
        string _notes;

		//Property methods

		public string FirstName
		{
			get { return _firstName; }
				
			set
			{
				_firstName = value;
				RaisePropertyChangedEvent("FirstName");
			}
		}

		public string MiddleName
		{
			get { return _middleName; }

			set
			{
				_middleName = value;
				RaisePropertyChangedEvent("MiddleName");
			}
		}

		public string LastName
		{
			get { return _lastName; }

			set
			{
				_lastName = value;
				RaisePropertyChangedEvent("LastName");
			}
		}

        //TODO: Add GetFullName() function er something

		public DateTime BirthDate
		{
			get { return _birthDate; }

			set
			{
				_birthDate = value;
				RaisePropertyChangedEvent("BirthDate");
			}
		}

		public SEX Sex
		{
			get { return _sex; }

			set
			{
				_sex = value;
				RaisePropertyChangedEvent("Sex");
			}
		}

        public String GetSexAsString()
        {
            switch (_sex)
            {
                case SEX.MALE:
                    return "Male";
                case SEX.FEMALE:
                    return "Female";
                case SEX.OTHER:
                    return "Other";
                default:
                    return "Undefined";
            }
        }

		public int HealthID
		{
			get { return _healthID; }

			set
			{
				_healthID = value;
				RaisePropertyChangedEvent("HealthID");
			}
		}

        internal string GetHealthIdAsString()
        {
            return _healthID.ToString().Substring(0, 5) + "-" + _healthID.ToString().Substring(4);
        }


        public string Street
		{
			get { return _street; }

			set
			{
				_street = value;
				RaisePropertyChangedEvent("Street");
			}
		}

		public string City
		{
			get { return _city; }

			set
			{
				_city = value;
				RaisePropertyChangedEvent("City");
			}
		}

		public PROVINCE Province
		{
			get { return _province; }

			set
			{
				_province = value;
				RaisePropertyChangedEvent("Province");
			}
		}

		public string PostalCode
		{
			get { return _postalCode; }

			set
			{
				_postalCode = value;
				RaisePropertyChangedEvent("PostalCode");
			}
		}

        public string Business
        {
            get { return _business; }
            set
            {
                _business = value;
                RaisePropertyChangedEvent("Business");
            }
        }

		public string Phone
		{
			get { return _phone; }

			set
			{
				_phone = value;
				RaisePropertyChangedEvent("Phone");
			}
		}

		public string Cell
		{
			get { return _cell; }

			set
			{
				_cell = value;
				RaisePropertyChangedEvent("Cell");
			}
		}

		public string Email
		{
			get { return _email; }

			set
			{
				_email = value;
				RaisePropertyChangedEvent("Email");
			}
		}

        public string Notes
        {
            get { return _notes; }

            set
            {
                _notes = value;
                RaisePropertyChangedEvent("Notes");
            }
        }

        public static SEX SexStringToEnum(string sex)
        {
            if (sex == "Male") return SEX.MALE;
            if (sex == "Female") return SEX.FEMALE;

            return SEX.OTHER;
        }

        public static PROVINCE ProvinceStringToEnum(string prov)
        {
            if (prov == "Alberta") return PROVINCE.AB;
            if (prov == "British Columbia") return PROVINCE.BC;
            if (prov == "Manitoba") return PROVINCE.MB;
            if (prov == "New Brunswick") return PROVINCE.NB;
            if (prov == "Newfoundland and Labrador") return PROVINCE.NL;
            if (prov == "Nova Scotia") return PROVINCE.NS;
            if (prov == "Northwest Territories") return PROVINCE.NT;
            if (prov == "Nunavut") return PROVINCE.NU;
            if (prov == "Ontario") return PROVINCE.ON;
            if (prov == "Prince Edward Island") return PROVINCE.PE;
            if (prov == "Quebec") return PROVINCE.QC;
            if (prov == "Saskatchewan") return PROVINCE.SK;
            if (prov == "Yukon") return PROVINCE.YT;

            //if all else fails, assume alberta
            return PROVINCE.AB;
        }

		public EmergencyContact EmergencyContact
		{
			get { return _emergencyContact; }

			set
			{
				_emergencyContact = value;
				RaisePropertyChangedEvent("EmergencyContact");
			}
		}
	}
}