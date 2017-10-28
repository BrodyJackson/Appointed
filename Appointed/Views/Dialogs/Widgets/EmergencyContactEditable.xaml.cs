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
using Appointed.Views.Controls;

namespace Appointed.Views.Dialogs.Widgets
{
    /// <summary>
    /// Interaction logic for EmergencyContactEditor.xaml
    /// </summary>
    public partial class EmergencyContactEditable : UserControl
    {
        public EmergencyContactEditable()
        {
            InitializeComponent();
        }

        // Hide all labels and show all input text controls/save-discard options.
        private void OnMouseLeftRelease_Edit(object sender, MouseButtonEventArgs e)
        {
            Image I = sender as Image;
            Grid G = I.Parent as Grid;

            var labels = G.Children.OfType<Label>();
            if (labels.ElementAt(0).Visibility == Visibility.Visible)
                setLabelVisibility(G, Visibility.Hidden);
            else
                setLabelVisibility(G, Visibility.Visible);


            var inputs = G.Children.OfType<InputText>();
            if (labels.ElementAt(0).Visibility == Visibility.Visible)
                setInputControlVisibility(G, Visibility.Hidden);
            else
                setInputControlVisibility(G, Visibility.Visible);


            if (buttonPartition.Visibility == Visibility.Visible)
                buttonPartition.Visibility = Visibility.Collapsed;
            else
                buttonPartition.Visibility = Visibility.Visible;
        }


        // Hide all input text controls/save-discard options and show all labels.
        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            Button B = sender as Button;
            Grid G = B.Parent as Grid;
            Grid G2 = G.Parent as Grid;

            setLabelVisibility(G2, Visibility.Visible);
            setInputControlVisibility(G2, Visibility.Hidden);
            buttonPartition.Visibility = Visibility.Collapsed;
        }


        // Hide all input text controls/save-discard options and alter label contents.
        private void OnMouseLeftRelease_Save(object sender, MouseButtonEventArgs e)
        {
            Button B = sender as Button;
            Grid G = B.Parent as Grid;
            Grid G2 = G.Parent as Grid;

            // Get text from input texts and set labels accordingly.

            setLabelVisibility(G2, Visibility.Visible);
            setInputControlVisibility(G2, Visibility.Hidden);
            buttonPartition.Visibility = Visibility.Collapsed;
        }





        private void setLabelVisibility(Grid g, Visibility v)
        {
            var labels = g.Children.OfType<Label>();
            foreach (Label l in labels)
                l.Visibility = v;
        }


        private void setInputControlVisibility(Grid g, Visibility v)
        {
            var inputs = g.Children.OfType<InputText>();
            foreach (InputText i in inputs)
                i.Visibility = v;
        }


    }
}
