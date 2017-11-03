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

        public SearchBar()
        {
            //Manual workaround for showing hint text

            InitializeComponent();

            InputField.Hint = "Search by name or ID...";
            InputField.HintForground = Brushes.Gray;

            InputField.ShowHintText(InputField.TextField);

        }
    }
}
