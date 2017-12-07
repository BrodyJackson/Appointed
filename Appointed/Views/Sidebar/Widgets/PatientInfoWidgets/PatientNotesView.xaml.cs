using Appointed.Classes;
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

namespace Appointed.Views.Sidebar.Widgets.PatientInfoWidgets
{
    /// <summary>
    /// Interaction logic for PatientNotesView.xaml
    /// </summary>
    public partial class PatientNotesView : UserControl
    {
        public Patient patient;

        public bool HasChanges { get; private set; }

        public PatientNotesView()
        {
            InitializeComponent();

            HasChanges = false;
            this.Loaded += PatientNotesViewLoaded;
        }

        private void PatientNotesViewLoaded(object sender, RoutedEventArgs e)
        {
            CommentBox.Text = patient.Notes;
        }

        private void SaveNotesBtn_Click(object sender, RoutedEventArgs e)
        {
            patient.Notes = CommentBox.Text;
            HasChanges = false;
        }

        private void CommentBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (CommentBox.Text != patient.Notes)
                HasChanges = true;
            else
                HasChanges = false;
        }
    }
}
