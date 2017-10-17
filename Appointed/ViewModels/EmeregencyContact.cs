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
	public class EmeregencyContact
	{
		//Constant values for relationship
		const int OTHER = 0;
		const int SPOUSE = 1;
		const int PARENT = 2;
		const int CHILD = 3;
		const int EXTENDED_FAMILY = 4;
		const int FRIEND = 5;

		string _emergencyName;
		int _emergencyRelation;          //Use constant values
		string _emergencyPhone;

		//Properties

		public string EmergencyName
		{
			get { return _emergencyName; }

			set
			{
				_emergencyName = value;
				RaisePropertyChangedEvent("EmergencyName");
			}
		}

		public int EmergencyRelation
		{
			get { return _emergencyRelation; }

			set
			{
				_emergencyRelation = value;
				RaisePropertyChangedEvent("EmergencyRelation");
			}
		}

		public string Phone
		{
			get { return _relation; }

			set
			{
				_phone = value;
				RaisePropertyChangedEvent("EmergencyPhone");
			}
		}
	}

}
