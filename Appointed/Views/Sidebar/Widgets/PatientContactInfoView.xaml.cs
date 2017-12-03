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
    /// Interaction logic for PatientContactInfoView.xaml
    /// </summary>
    public partial class PatientContactInfoView : UserControl
    {
        Patient P;

        Boolean editing;
        public PatientContactInfoView()
        {
            InitializeComponent();
            editing = false;
            P = (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient;
            PatientHomePhone.Text = P.Phone;
            PatientCellPhone.Text = P.Cell;
            PatientWorkPhone.Text = P.Cell;
            PatientEmail.Text = P.Email;
            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (editing == false)
            {
                editing = true;
                //new EditPatientContactInfo(ID).ShowDialog();
                HomeP.Text = P.Phone;
                CellP.Text = P.Cell;
                WorkP.Text = P.Business;
                EmailE.Text = P.Email;
                Edit.Visibility = Visibility.Visible;
            }
            else {
                editing = false;
                P.Phone = HomeP.Text;
                P.Cell = CellP.Text;
                P.Business = WorkP.Text;
                P.Email = EmailE.Text;
                PatientHomePhone.Text = P.Phone;
                PatientCellPhone.Text = P.Cell;
                PatientWorkPhone.Text = P.Business;
                PatientEmail.Text = P.Email;
                Edit.Visibility = Visibility.Hidden;
            }
        }
    }
}
