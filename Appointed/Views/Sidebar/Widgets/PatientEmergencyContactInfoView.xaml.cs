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

namespace Appointed.Views.Sidebar.Widgets
{
    /// <summary>
    /// Interaction logic for PatientEmergencyContactInfo.xaml
    /// </summary>
    public partial class PatientEmergencyContactInfoView: UserControl
    {
        public PatientEmergencyContactInfoView()
        {
            InitializeComponent();

            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            new EditPatientEmergencyContacts().ShowDialog();
        }
    }
}
