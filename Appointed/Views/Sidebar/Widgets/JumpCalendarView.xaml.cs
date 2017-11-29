using Appointed.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for JumpCalendarView.xaml
    /// </summary>
    public partial class JumpCalendarView : UserControl
    {
        public JumpCalendarView()
        {
            InitializeComponent();

            //Blackout days that will cause exception

            AppointmentViewModel AVM = (App.Current.MainWindow.DataContext as DayInformationViewModel).AVM;

            DateTime beginningOfAllTime = AVM.BeginningOfAllTime;

            Calendar.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, beginningOfAllTime));
            Calendar.BlackoutDates.Add(new CalendarDateRange(beginningOfAllTime.AddDays(AVM.NumOfDaysPopulated), DateTime.MaxValue));

        }

    
    }
}
