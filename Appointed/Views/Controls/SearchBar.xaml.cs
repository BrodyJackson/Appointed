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

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for SearchBarView.xaml
    /// </summary>
    public partial class SearchBar : UserControl
    {

        public event EventHandler<EventArgs> SearchTextChanged;
        /// <summary>
        /// Invoked when search button is clicked, or enter is pressed with the input field focused
        /// </summary>
        public event EventHandler<EventArgs> Search;

        public SearchBar()
        {
            //Manual workaround for showing hint text

            InitializeComponent();

            InputField.Hint = "Search by name or ID...";
            InputField.HintForground = Brushes.Gray;

            InputField.ShowHintText(InputField.TextField);

            SearchBtn.Click += SearchBtn_Click;
            InputField.KeyUp += InputField_EnterUp;

        }

        private void InputField_EnterUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (InputField.TextField.Text != InputField.Hint && !String.IsNullOrWhiteSpace(InputField.TextField.Text))
                {
                    Search?.Invoke(sender, e);
                }
            }
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(InputField.TextField.Text != InputField.Hint && !String.IsNullOrWhiteSpace( InputField.TextField.Text ))
            {
                Search?.Invoke(sender, e);
            }
        }
    }
}
