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
	public class EmeregencyContact : ObservableObject
	{
		enum relationship { Other, Spouse, Parent, Child, Extended_Family, Friend}

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

		public string EmergencyPhone
		{
			get { return _emergencyPhone; }

			set
			{
				_emergencyPhone = value;
				RaisePropertyChangedEvent("EmergencyPhone");
			}
		}
	}

}
