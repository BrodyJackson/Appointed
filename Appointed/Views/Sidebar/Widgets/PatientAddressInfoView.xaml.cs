using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views.Dialogs;
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

namespace Appointed.Views.Sidebar.Widgets
{
    /// <summary>
    /// Interaction logic for PatientAddressInfoView.xaml
    /// </summary>
    public partial class PatientAddressInfoView : UserControl
    {
        int ID;
        public PatientAddressInfoView()
        {
            InitializeComponent();

            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;

        }
        public void StartUp(int ID)
        {
            this.ID = ID;
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Patient P = DIVM.PVM.GetPatient(ID);
            PatientStreetAddr.Text = P.Address;
            PatientRegion.Text = P.Province.ToString();
            PatientPostal.Text = P.PostalCode;
        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            new EditPatientAddress(ID).ShowDialog();
        }
    }
}
