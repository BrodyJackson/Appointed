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
    /// Interaction logic for AppointmentTimeSlotView.xaml
    /// </summary>
    public partial class AppointmentTimeSlotView : UserControl
    {
        public AppointmentTimeSlotView()
        {
            InitializeComponent();
        }

        private void OnMouseEnterAppointmentSlot(object sender, MouseEventArgs e)
        {
            this.ApptSlotRect.Opacity = 100;
            this.ApptSlotRect.RadiusX = 2;
            this.ApptSlotRect.RadiusY = 2;
            this.ApptSlotRect.StrokeThickness = 3;
            this.ApptSlotText.Foreground = Brushes.BlueViolet;
        }

        private void OnMouseLeaveAppointmentSlot(object sender, MouseEventArgs e)
        {
            this.ApptSlotRect.Opacity = 75;
            this.ApptSlotRect.RadiusX = 4;
            this.ApptSlotRect.RadiusY = 4;
            this.ApptSlotRect.StrokeThickness = 1;
            this.ApptSlotText.Foreground = Brushes.Black;
        }
    }
}
