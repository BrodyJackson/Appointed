using Appointed.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Appointed
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        //Global State Vars
        public static Dictionary<string, bool> CalendarDocFilter { get; set; }
        public static Dictionary<string, bool> CalendarApptFilter { get; set; }

        public App()
        {
            //Initialize Global State Vars

            CalendarDocFilter = new Dictionary<string, bool>();
            CalendarApptFilter = new Dictionary<string, bool>();

            CalendarDocFilter.Add("Pearson", true);
            CalendarDocFilter.Add("Paulsen", true);
            CalendarDocFilter.Add("Specter", true);

            CalendarApptFilter.Add("Standard", true);
            CalendarApptFilter.Add("Consultation", true);


        }


    }
}
