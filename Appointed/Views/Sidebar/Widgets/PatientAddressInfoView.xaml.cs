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
        Patient P;
        Boolean editing;
        public PatientAddressInfoView()
        {
            editing = false;
            InitializeComponent();
            P = (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient;
            PatientStreetAddr.Text = P.Street;
            PatientRegion.Text = P.City + P.Province.ToString();
            PatientPostal.Text = P.PostalCode;
 
            

            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;

        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (editing == false)
            {
                Address.Text = P.Street;
                prov.SelectedIndex = (Patient.ProvinceEnumToNum(P.Province));
                PostalC.Text = P.PostalCode;
                City.Text = P.City;
                edit.Visibility = Visibility.Visible;
                editing = true;
            }
            else
            {
                P.Street = Address.Text;
                P.Province = Patient.ProvinceStringToEnum(prov.Text);
                PatientStreetAddr.Text = P.Street;
                PatientRegion.Text = P.City + P.Province.ToString();
                PatientPostal.Text = P.PostalCode;
                edit.Visibility = Visibility.Hidden;
                editing = false;
            }
        }
    }
}
