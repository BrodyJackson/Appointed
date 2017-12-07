using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views.Sidebar;
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
    public class DateSelectedEventArgs : EventArgs
    {
        public DateTime Date { get; private set; }
        public bool ShouldShiftView { get; private set; }

        public DateSelectedEventArgs(DateTime date, bool doShift)
        {
            Date = date;
            ShouldShiftView = doShift;
        }
    }

    /// <summary>
    /// Interaction logic for DatePicker.xaml
    /// </summary>
    public partial class DatePicker : UserControl
    {
        public event EventHandler<RoutedEventArgs> SelectedDateChanged;

        public DateTime? DateSelected { get; set; }

        private Brush _textBorderBrush;

        public event EventHandler OnCalendarLoaded;
        public event EventHandler<DateSelectedEventArgs> OnDateChosen;

        public CalendarBlackoutDatesCollection CalendarBlackoutDates { get; set; }

        public DatePicker()
        {
            InitializeComponent();

            CalendarBlackoutDates = new CalendarBlackoutDatesCollection(new Calendar());

            _textBorderBrush = InputText.TextField.BorderBrush;

            DateSelected = null;

            ShowCalendarButton.Click += ShowCalendarButton_Click;

            InputText.TextField.TextChanged += DateTextInputChanged;

        }

        private void ShowCalendarButton_Click(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            Calendar calendar = new Calendar
            {
                Margin = new Thickness(0, -3, 0, -3),
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

            OnCalendarLoaded?.Invoke(calendar, null);

            calendar.SelectedDatesChanged += Calendar_SelectedDatesChanged;
            //calendar.SelectedDatesChanged += DIVM.ChangeHighlight;
            calendar.Focus();
        }


        private CustomPopupPlacement[] CustomPopupCallback(Size popupSize, Size targetSize, Point offset)
        {
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

            if (c.SelectedDate.HasValue)
            {
                DateSelected = new DateTime(c.SelectedDate.Value.Year, c.SelectedDate.Value.Month, c.SelectedDate.Value.Day);

                InputText.TextField.Text = DateSelected.Value.ToString("yyyy-MM-dd");

                (c.Parent as Popup).IsOpen = false;
                InputText.TextField.Focus();

                OnDateChosen?.Invoke(this, new DateSelectedEventArgs(DateSelected.Value, true));
                SelectedDateChanged?.Invoke(this, null);
            }
        }


        private void DateTextInputChanged(object sender, TextChangedEventArgs e)
        {
            TextBox input = sender as TextBox;

            if (input.Text != InputText.Hint )
            {
                DateTime date;
                if (input.Text.Length == 10 && DateTime.TryParse(input.Text, out date))
                {
                    if (!CalendarBlackoutDates.Contains(date))
                    {
                        DateSelected = new DateTime(date.Year, date.Month, date.Day);
                        input.BorderBrush = _textBorderBrush;

                        if (DateSelected.HasValue)
                            OnDateChosen?.Invoke(input, new DateSelectedEventArgs(DateSelected.Value, false));
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
