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

namespace Appointed.Views.Sidebar.ListItems
{
    /// <summary>
    /// Interaction logic for Alert.xaml
    /// </summary>
    public partial class Alert : UserControl
    {

        private AlertBoxView _parent;
        private Classes.Alert _alert;

        public Alert(Classes.Alert alert, AlertBoxView parent)
        {
            InitializeComponent();
            _parent = parent;
            _alert = alert;
            AlertTitle.Text = alert.Title;
            AlertActionBtn.Content = alert.ButtonText;
        }

        private void AlertDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            _parent.RemoveAlert(_alert);
            _parent.UpdateAlertsBox();
        }
    }
}
