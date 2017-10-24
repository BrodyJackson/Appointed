using System;
using Appointed.Events;
using Appointed.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.ViewModels
{
	public class Patient : ObservableObject
	{
		//Constant values

		enum SEX {Other, Male, Female };

		enum PROVINCE {AB, BC, MB, NB, NL, NT, NS, NU, ON, PE, QC, SK, YT };

		//Provinces (and territories)
		const int AB = 0;
		const int BC = 1;
		const int MB = 2;
		const int NB = 3;
		const int NL = 4;
		const int NT = 5;
		const int NS = 6;
		const int NU = 7;
		const int ON = 8;
		const int PE = 9;
		const int QC = 10;
		const int SK = 11;
		const int YT = 12;

		//General info
		string _firstName;
		string _middleName;
		string _lastName;
		DateTime _birthDate;
		int _sex;               //Use constant values
		int _healthID;

		//Address
		string _street;
		string _suite;
		string _city;
		int _province;          //Use constant values
		string _postalCode;

		//Contact
		string _phone;
		string _cell;
		string _email;

		//Emergency Contact
		EmeregencyContact _emergencyContact;

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

		public DateTime BirthDate
		{
			get { return _birthDate; }

			set
			{
				_birthDate = value;
				RaisePropertyChangedEvent("BirthDate");
			}
		}

		public int Sex
		{
			get { return _sex; }

			set
			{
				_sex = value;
				RaisePropertyChangedEvent("Sex");
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

		public string Street
		{
			get { return _street; }

			set
			{
				_street = value;
				RaisePropertyChangedEvent("Street");
			}
		}

		public string Suite
		{
			get { return _suite; }

			set
			{
				_suite = value;
				RaisePropertyChangedEvent("Suite");
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

		public int Province
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

		public EmeregencyContact EmergencyContact
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