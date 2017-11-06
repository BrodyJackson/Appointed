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
using System.Windows.Shapes;
using Appointed.ViewModels;
using Appointed.Classes;

namespace Appointed.Views.Controls
{
    /// <summary>
    /// Interaction logic for ShowableCalendar.xaml
    /// </summary>
    public partial class ShowableCalendar : Window
    {
        public ShowableCalendar()
        {
            InitializeComponent();
        }


        void DateSelected(object sender, SelectionChangedEventArgs e)
        {
            DayInformationViewModel DIVM = Application.Current.MainWindow.DataContext as DayInformationViewModel;

            Calendar c = sender as Calendar;
            DateTime dt = new DateTime();

            if (c.SelectedDate != null)
                dt = ((DateTime)c.SelectedDate).Date;
            else
                this.Close();

            DIVM._activeDate.Day = dt.Day;
            DIVM._activeDate.Month = dt.Month;
            DIVM._activeDate.Year = dt.Year;


            this.Close();
        }


    }
}
