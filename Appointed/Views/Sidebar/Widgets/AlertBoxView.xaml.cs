using Appointed.Classes;
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

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for AlertBoxView.xaml
    /// </summary>
    public partial class AlertBoxView : UserControl
    {
        List<Alert> _alerts = new List<Alert>();

        public AlertBoxView()
        {
            InitializeComponent();
        }

        public void AddAlert(Alert a)
        {
            _alerts.Insert(_alerts.Count, a);
        }

        public void RemoveAlert(Alert a)
        {
            _alerts.Remove(a);
        }

        public void UpdateAlertsBox()
        {
            AlertsList.Children.Clear();

            foreach(Alert a in _alerts)
            {
                ListItems.Alert alert = new ListItems.Alert(a, this);
                AlertsList.Children.Add(alert);
            }
        }
    }
}
