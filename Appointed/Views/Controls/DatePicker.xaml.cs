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

namespace Appointed.Views.Controls
{
    /// <summary>
    /// Interaction logic for DatePicker.xaml
    /// </summary>
    public partial class DatePicker : UserControl
    {
        public DateTime DateSelected { get; set; }
        public bool IsValidDate { get; protected set; }

        private Brush _textBorderBrush;

        public DatePicker()
        {
            InitializeComponent();

            _textBorderBrush = InputText.TextField.BorderBrush;

            InputText.TextField.TextChanged += DateTextInputChanged;

            DateSelected = new DateTime();
            IsValidDate = false;
        }

        private void DateTextInputChanged(object sender, TextChangedEventArgs e)
        {
            TextBox input = sender as TextBox;

            if (input.Text != InputText.Hint)
            {

                if (DateTime.TryParse(input.Text, out DateTime date))
                {
                    DateSelected = date;
                    IsValidDate = true;
                    input.BorderBrush = _textBorderBrush;
                }
                else
                {
                    DateSelected = new DateTime();
                    IsValidDate = false;
                    input.BorderBrush = Brushes.Red;
                }
            }
            else
            {
                DateSelected = new DateTime();
                IsValidDate = false;
                input.BorderBrush = _textBorderBrush;
            }
        }
    }
}
