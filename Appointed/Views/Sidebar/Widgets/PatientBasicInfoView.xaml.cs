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
    /// Interaction logic for PatientBasicInfoView.xaml
    /// </summary>
    public partial class PatientBasicInfoView : UserControl
    {
        int ID;
        public PatientBasicInfoView()
        {
            
            InitializeComponent();
           

            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }
        public void StartUp(int ID)
        {
            this.ID = ID;
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Patient P = DIVM.PVM.GetPatient(ID);
            PatientName.Text = P.FirstName + " " + P.LastName;
            PatientID.Text = P.GetHealthIdAsString();
            PatientSex.Text = P.GetSexAsString();
            PatientBirthday.Text = P.BirthDate.ToShortDateString();
        }
        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            new EditPatientGeneralInfo(ID).ShowDialog();
        }
    }
}
