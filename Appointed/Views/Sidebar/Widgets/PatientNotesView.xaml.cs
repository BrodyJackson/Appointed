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
        Patient P;
        Boolean editing;
        public PatientNotesView()
        { 
            InitializeComponent();
            P = (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient;
            editing = false;
            Comments.Text = P.Notes;
            EditBtn.MouseLeftButtonUp += EditBtn_MouseLeftButtonUp;
        }

        private void EditBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            P.Notes = Comments.Text;
            Comments.Text = P.Notes;
            
        }
    }
}
