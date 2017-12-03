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
        Patient P;
        Boolean editing;
        int ID;
        public PatientEmergencyContactInfoView()
        {
            P = (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient;
            editing = false;
            InitializeComponent();
            ContactName.Text = P.EmergencyContact.EmergencyName;
            ContactPhone.Text = P.EmergencyContact.EmergencyPhone;
            ContactRelation.Text = P.EmergencyContact.EmergencyRelation;
            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (editing == false)
            {
                editing = true;
                Name.Text = P.EmergencyContact.EmergencyName;
                Phone.Text = P.EmergencyContact.EmergencyPhone;
                Relation.Text = P.EmergencyContact.EmergencyRelation;
                Edit.Visibility = Visibility.Visible;
            }
            else
            {
                editing = false;
                P.EmergencyContact.EmergencyName = Name.Text;
                P.EmergencyContact.EmergencyPhone = Phone.Text;
                P.EmergencyContact.EmergencyRelation = Relation.Text;
                ContactName.Text = P.EmergencyContact.EmergencyName;
                ContactPhone.Text = P.EmergencyContact.EmergencyPhone;
                ContactRelation.Text = P.EmergencyContact.EmergencyRelation;
                Edit.Visibility = Visibility.Hidden;
            }
        }
    }
}
