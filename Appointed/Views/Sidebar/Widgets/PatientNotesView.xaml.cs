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
    /// Interaction logic for PatientNotesView.xaml
    /// </summary>
    public partial class PatientNotesView : UserControl
    {

        public PatientNotesView()
        { 
            
            InitializeComponent();

            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }
        public void StartUp(int ID)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Patient P = DIVM.PVM.GetPatient(ID);
            //Get this done
            Comments.Text = P.Address;
        }
        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
