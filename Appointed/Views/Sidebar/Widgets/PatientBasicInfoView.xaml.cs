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
        Patient P;
        Boolean editing;
        public PatientBasicInfoView()
        {
            P = (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient;
            editing = false;
            
           
            InitializeComponent();
            PatientName.Text = P.FirstName + " " + P.LastName;
            PatientID.Text = P.GetHealthIdAsString();
            PatientSex.Text = P.GetSexAsString();
            PatientBirthday.Text = P.BirthDate.ToShortDateString();


            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (editing == false)
            {
                FName1.Text = P.FirstName;
                MName.Text = P.MiddleName;
                LName.Text = P.LastName;
                HID.Text = P.HealthID.ToString();
                BirthD.Text = P.BirthDate.ToString();
                Normal.Visibility = Visibility.Hidden;
                Edit.Visibility = Visibility.Visible;
                editing = true;
            }
            else
            {
                P.FirstName = FName1.Text;
                P.MiddleName = MName.Text;
                P.LastName = LName.Text;
                int x = 0;
                String HealthID = HID.Text;
                HealthID.Replace("-", "");
                Int32.TryParse(HealthID, out x);
                P.HealthID = x;
                P.BirthDate = DateTime.Parse(PatientBirthday.Text);
                if (sex.Text.Equals("Female"))
                    P.Sex = Patient.SEX.FEMALE;
                else if (sex.Text.Equals("Male"))
                    P.Sex = Patient.SEX.MALE;
                else if (sex.Text.Equals("Other"))
                    P.Sex = Patient.SEX.OTHER;
                editing = false;
                PatientName.Text = P.FirstName + " " + P.LastName;
                PatientID.Text = P.GetHealthIdAsString();
                PatientSex.Text = P.GetSexAsString();
                PatientBirthday.Text = P.BirthDate.ToShortDateString();
                Edit.Visibility = Visibility.Hidden;
                Normal.Visibility = Visibility.Visible;

            }
        }
    }
}
