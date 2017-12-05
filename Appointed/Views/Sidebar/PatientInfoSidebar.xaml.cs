using Appointed.Classes;
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

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for PatientInfoSidebar.xaml
    /// </summary>
    public partial class PatientInfoSidebar : UserControl
    {
        public Patient Patient { get; private set; }

        public PatientInfoSidebar(Patient patient)
        {
            InitializeComponent();
            Patient = patient;
            BasicInfo.patient = patient;
        }
    }
}
