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

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for ThreeDayHeaderView.xaml
    /// </summary>
    public partial class ThreeDayHeaderView : UserControl
    {
        public ThreeDayHeaderView()
        {
            InitializeComponent();
        }

        private void OnScrollDayShifter(object sender, MouseWheelEventArgs e)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            if (DIVM.ShiftView.CanExecute(null))
                if (e.Delta > 0)
                    ShiftScheduleView(3);
                else
                    ShiftScheduleView(-3);
        }

        private void OnLargeShiftRight(object sender, MouseButtonEventArgs e)
        {
            ShiftScheduleView(3);
        }
        private void OnSmallShiftRight(object sender, MouseButtonEventArgs e)
        {
            ShiftScheduleView(1);
        }
        private void OnLargeShiftLeft(object sender, MouseButtonEventArgs e)
        {
            ShiftScheduleView(-3);
        }
        private void OnSmallShiftLeft(object sender, MouseButtonEventArgs e)
        {
            ShiftScheduleView(-1);
        }


        void ShiftScheduleView(int amount)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            if (DIVM.ShiftView.CanExecute(null))
                DIVM.ShiftView.Execute(amount);
        }

     }
}
