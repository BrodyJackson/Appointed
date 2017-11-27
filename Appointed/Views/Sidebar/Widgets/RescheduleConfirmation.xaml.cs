using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Appointed.Views.Sidebar.Widgets
{
    /// <summary>
    /// Interaction logic for RescheduleConfirmation.xaml
    /// </summary>
    public partial class RescheduleConfirmation : UserControl
    {
        public RescheduleConfirmation()
        {
            InitializeComponent();
        }

        private void OnCancelReschedule(object sender, MouseButtonEventArgs e)
        {
            Popup p = this.Parent as Popup;

            p.StaysOpen = false;
            p.IsOpen = false;
        }
    }
}
