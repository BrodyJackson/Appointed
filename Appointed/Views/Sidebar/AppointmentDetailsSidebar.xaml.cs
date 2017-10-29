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
using Appointed.Views.Dialogs;
using Appointed.Views;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AppointmentDetailsSidebar : UserControl
    {
        public AppointmentDetailsSidebar()
        {
            InitializeComponent();

            
        }

        private void OnMouseLeftRelease_CheckIn(object sender, MouseButtonEventArgs e)
        {
            Button checkIn = sender as Button;

            if (checkIn.Content.ToString() == "Check In")
            {
                checkIn.Content = "Patient Arrived";
                //checkIn.Background = Brushes.Magenta;
                checkIn.ToolTip = "Click To Undo Check In";
            }
            else
            {
                checkIn.Content = "Check In";
                //checkIn.Background = Brushes.DodgerBlue;
                checkIn.ToolTip = "Click To Check Patient In";
            }


            //Window w = new EditPatientEmergencyContacts();
            //w.Show();
        }

        private void OnMouseLeftRelease_Modify(object sender, MouseButtonEventArgs e)
        {
            //ModifyAppointmentDialog window = new ModifyAppointmentDialog();
            //window.Show();
        }


    }
}
