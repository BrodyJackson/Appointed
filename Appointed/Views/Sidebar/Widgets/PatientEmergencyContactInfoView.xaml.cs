using Appointed.Classes;
using Appointed.ViewModels;
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
        int ID;
        public PatientEmergencyContactInfoView()
        {
            
            InitializeComponent();

            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }
        public void StartUp(int ID)
        {
            this.ID = ID;
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Patient P = DIVM.PVM.GetPatient(ID);
            ContactName.Text = P.EmergencyContact.EmergencyName;
            ContactPhone.Text = P.EmergencyContact.EmergencyPhone;
            ContactRelation.Text = P.EmergencyContact.EmergencyRelation.ToString();
        }
        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            new EditPatientEmergencyContacts(ID).ShowDialog();
        }
    }
}
