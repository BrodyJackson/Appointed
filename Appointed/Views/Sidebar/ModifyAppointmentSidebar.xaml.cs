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


namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for ModifyAppointmentDialog.xaml
    /// </summary>
    public partial class ModifyAppointmentSidebar : UserControl
    {
        private bool _reminderEnabled = true;

        public ModifyAppointmentSidebar()
        {
            InitializeComponent();
            ReminderToggle.IsChecked = true;
        }

        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            _reminderEnabled = !_reminderEnabled;

            RemDaysLable.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemTODLable.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemType.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemTypeLable.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemTOD.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemDays.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ApptType.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToShortTimeString();
            }
        }
    }
}
