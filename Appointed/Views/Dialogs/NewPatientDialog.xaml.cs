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

        public enum EXIT_ACTION { SAVE, SAVEBOOK, DISCARD };

        public EXIT_ACTION ExitAction { get; private set; }

        public NewPatientDialog()
        {
            InitializeComponent();

            //Set Exit Actions On Close Event
            Closing += (object sender, System.ComponentModel.CancelEventArgs e) => { ExitAction = EXIT_ACTION.DISCARD; };
            DiscardBtn.Click += (object sender, RoutedEventArgs e) => { ExitAction = EXIT_ACTION.DISCARD; };
            SaveBtn.Click += (object sender, RoutedEventArgs e) => { ExitAction = EXIT_ACTION.SAVE; };
            SaveBookBtn.Click += (object sender, RoutedEventArgs e) => { ExitAction = EXIT_ACTION.SAVEBOOK; };
        }



    }
}
