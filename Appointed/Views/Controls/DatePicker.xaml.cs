using Appointed.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        public DateTime? DateSelected { get; set; }

        private Brush _textBorderBrush;

        public DatePicker()
        {
            InitializeComponent();

            _textBorderBrush = InputText.TextField.BorderBrush;

            DateSelected = null;

            ShowCalendarButton.Click += ShowCalendarButton_Click;

            InputText.TextField.TextChanged += DateTextInputChanged;

        }

        private void ShowCalendarButton_Click(object sender, RoutedEventArgs e)
        {
            Popup popup = new Popup();
            Calendar calendar = new Calendar();
            calendar.Margin = new Thickness(0, -3, 0, -3);
            calendar.SelectedDate = (DateSelected != null) ? DateSelected.Value : DateTime.Today;
            calendar.DisplayDate = (DateSelected != null) ? DateSelected.Value : DateTime.Today;
            popup.Child = calendar;
            popup.Placement = PlacementMode.Bottom;
            popup.PlacementTarget = this;
            popup.IsOpen = true;
            popup.HorizontalOffset = (Math.Abs(calendar.ActualWidth - this.ActualWidth)) / -2d;
            popup.AllowsTransparency = true;
            popup.StaysOpen = false;
            calendar.SelectedDatesChanged += Calendar_SelectedDatesChanged;
            calendar.Focus();

        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar c = sender as Calendar;
            DateSelected = c.SelectedDate;
            InputText.TextField.Text = DateSelected.Value.ToShortDateString();
            (c.Parent as Popup).IsOpen = false;
            InputText.TextField.Focus();
        }

        private void DateTextInputChanged(object sender, TextChangedEventArgs e)
        {
            TextBox input = sender as TextBox;

            if (input.Text != InputText.Hint)
            {

                if (DateTime.TryParse(input.Text, out DateTime date))
                {
                    DateSelected = date;
                    input.BorderBrush = _textBorderBrush;
                }
                else
                {
                    DateSelected = null;
                    input.BorderBrush = Brushes.Red;
                }
            }
            else
            {
                DateSelected = null;
                input.BorderBrush = _textBorderBrush;
            }
        }
    }
}
