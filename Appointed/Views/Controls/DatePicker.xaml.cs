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
using Appointed.ViewModels;

namespace Appointed.Views.Controls
{
    /// <summary>
    /// Interaction logic for DatePicker.xaml
    /// </summary>
    public partial class DatePicker : UserControl
    {
        public DatePicker()
        {
            InitializeComponent();
        }


        private void OnLeftMouseRelease_PickDate(object sender, MouseButtonEventArgs e)
        {
            Window w = new ShowableCalendar();

            Point pointW = Mouse.GetPosition(this);
            Point pointS = PointToScreen(pointW);

            w.Left = pointS.X;
            w.Top = pointS.Y;
            w.Show();


            w.Unloaded += new RoutedEventHandler(ShowableCalendarUnloaded);
        }


        void ShowableCalendarUnloaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            if (DIVM._activeDate.HasChanged)
                this.InputText.TextField.Text = DIVM._activeDate.Year.ToString() + '-' + DIVM._activeDate.Month.ToString() + '-' + DIVM._activeDate.Day.ToString();
        }
        
        
           
    }
}
