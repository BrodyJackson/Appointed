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
	public class EmergencyContact : ObservableObject
	{

        string _emergencyName;
		string _emergencyPhone;

        string _relation;

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

  		public string EmergencyRelation
		{
			get { return _relation; }

			set
			{
				_relation = value;
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
