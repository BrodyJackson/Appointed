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
            Calendar calendar = new Calendar
            {
                Margin = new Thickness(0, -3, 0, -3),
                SelectedDate = (DateSelected != null) ? DateSelected.Value : DateTime.Today,
                DisplayDate = (DateSelected != null) ? DateSelected.Value : DateTime.Today
            };

            Popup popup = new Popup
            {
                Child = calendar,
                StaysOpen = false,
                AllowsTransparency = true,
                PlacementTarget = this,
                Placement = PlacementMode.Custom
            };

            popup.CustomPopupPlacementCallback += CustomPopupCallback;

            popup.IsOpen = true;

            calendar.SelectedDatesChanged += Calendar_SelectedDatesChanged;
            calendar.Focus();
        }


        private CustomPopupPlacement[] CustomPopupCallback(Size popupSize, Size targetSize, Point offset)
        {
            //Console.WriteLine(popupSize.Height + " " + popupSize.Width);
            //Console.WriteLine(targetSize.Height);
            //Console.WriteLine(offset);

            CustomPopupPlacement popupPlacement = new CustomPopupPlacement()
            {
                Point = new Point(Math.Abs(popupSize.Width - targetSize.Width) / -2d, targetSize.Height)
            };

            CustomPopupPlacement popupPlacementAlt = new CustomPopupPlacement()
            {
                Point = new Point(0d, targetSize.Height)
            };

            return new CustomPopupPlacement[] { popupPlacement, popupPlacementAlt };
        }


        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar c = sender as Calendar;
            DateSelected = c.SelectedDate;

            InputText.TextField.Text = 
                DateSelected.Value.Year.ToString()  + "-" + 
                DateSelected.Value.Month.ToString() + "-" +
                DateSelected.Value.Day.ToString();

            (c.Parent as Popup).IsOpen = false;
            InputText.TextField.Focus();
        }

        private void DateTextInputChanged(object sender, TextChangedEventArgs e)
        {
            TextBox input = sender as TextBox;

            if (input.Text != InputText.Hint)
            {
                DateTime date;
                if (DateTime.TryParse(input.Text, out date))
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
