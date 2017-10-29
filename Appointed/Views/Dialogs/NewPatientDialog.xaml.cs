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
using System.Windows.Shapes;

namespace Appointed.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewPatientDialog.xaml
    /// </summary>
    public partial class NewPatientDialog : Window
    {
        public NewPatientDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please ensure all required fields are completed!", "Unable to Add Patient", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
