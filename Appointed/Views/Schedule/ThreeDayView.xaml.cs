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
    /// Interaction logic for ThreeDayView.xaml
    /// </summary>
    public partial class ThreeDayView : UserControl
    {
        public ThreeDayView()
        {
            InitializeComponent();
        }

        private void OnThreeDayViewVerticalScroll(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer sv = (ScrollViewer)sender;
            var scrollViewersOfGrid = ((Grid)sv.Parent).Children.OfType<ScrollViewer>();


            foreach (ScrollViewer scroller in scrollViewersOfGrid)
            {
                scroller.ScrollToVerticalOffset(sv.VerticalOffset - e.Delta);
               // Console.WriteLine("FOUND CHILD SCROLL VIEWER: \n");
            }

        }




/*
        private void OnThreeDayViewHorizontalScroll(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer sv = this.DayOneScroller;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - e.Delta);

            sv = this.DayTwoScroller;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - e.Delta);

            sv = this.DayThreeScroller;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - e.Delta);
        }
*/

        private void OnNextMonth(object sender, MouseButtonEventArgs e)
        {

        }

        private void OnPrevMonth(object sender, MouseButtonEventArgs e)
        {

        }

        private void OnDoctorNamesScroll(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer sv = (ScrollViewer)sender;
            var scrollViewersOfGrid = ((Grid)sv.Parent).Children.OfType<ScrollViewer>();


            foreach (ScrollViewer scroller in scrollViewersOfGrid)
            {
                scroller.ScrollToHorizontalOffset(sv.HorizontalOffset - e.Delta);
                Console.WriteLine("FOUND CHILD SCOLL VIEWER: \n");
            }
        }

        private void OnThreeDayViewKeyUp(object sender, KeyEventArgs e)
        {
            ScrollViewer sv = this.DayOneScroller;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - 10);

            sv = this.DayTwoScroller;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset + 10);

            sv = this.DayThreeScroller;
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - 10);

            if (e.Key == Key.Up)
            {
                ScrollViewer sv2 = (ScrollViewer)sender;
                var scrollViewersOfGrid = ((Grid)sv2.Parent).Children.OfType<ScrollViewer>();

                foreach (ScrollViewer scroller in scrollViewersOfGrid)
                {
                    scroller.ScrollToHorizontalOffset(sv.VerticalOffset + 10);
                    Console.WriteLine("FOUND CHILD SCOLL VIEWER: \n");
                }
            }
            else if (e.Key == Key.Down)
            {
                ScrollViewer sv2 = (ScrollViewer)sender;
                var scrollViewersOfGrid = ((Grid)sv2.Parent).Children.OfType<ScrollViewer>();

                foreach (ScrollViewer scroller in scrollViewersOfGrid)
                {
                    scroller.ScrollToHorizontalOffset(sv.VerticalOffset - 10);
                    Console.WriteLine("FOUND CHILD SCOLL VIEWER: \n");
                }
            }

        }
    }
}
