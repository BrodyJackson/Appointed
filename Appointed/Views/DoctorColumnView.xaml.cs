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
using Appointed.ViewModels;
using Appointed.Classes;



namespace Appointed.Views

{
    /// <summary>
    /// Interaction logic for DoctorColumn.xaml
    /// </summary>
    public partial class DoctorColumnView : UserControl
    {



        public DoctorColumnView()
        {
            InitializeComponent();

            this.InitializeComponent();

            this.Loaded += new RoutedEventHandler(DoctorColumnView_Loaded);
            

        }


        void DoctorColumnView_Loaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;
            DIVM.ScheduleShifted += new EventHandler<EventArgs>(OnScheduleAltered);

            OnScheduleAltered(null, new EventArgs());
        }





        void OnScheduleAltered(Object sender, EventArgs e)
        {
            int drColumn;
            int singleDayColumn;
            string bindingCode = "";
            int numPreceeding;

            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            // Every DoctorColumnView is a child of a Grid in a SingleDayView
            Grid SingleDayViewGrid = (Grid)this.Parent;

            // Get all sibling DrColumns then find this one's position by name.
            var DrColumns = SingleDayViewGrid.Children.OfType<DoctorColumnView>();
            for (drColumn = 0; drColumn < DrColumns.Count(); drColumn++)
            {
                if (DrColumns.ElementAt(drColumn).Name == this.Name)
                    break;
            }

            // Get the SingleDayView that is an ancestor of this DoctorColumnView
            SingleDayView SDV = (SingleDayView)SingleDayViewGrid.Parent;
            Console.WriteLine("Single Day View: " + SDV.Name);


            // Since the SingleDayView is in a ScrollViewer, i get that as it's parent
            ScrollViewer SingleDayScrollViewer = (ScrollViewer)SDV.Parent;
            Console.WriteLine("Scroll Viewer: " + SingleDayScrollViewer.Name);


            // Then I get the Grid that represents the ThreeDayView
            Grid ThreeDayViewGrid = (Grid)SingleDayScrollViewer.Parent;

            // Get all SingleDayViews of the ThreeDayView
            var SVs = ThreeDayViewGrid.Children.OfType<ScrollViewer>();
            int count = (int)SVs.Count();

            Console.WriteLine("Number of Scroll Viewers: " + count);

            // Get number of scroll viewer children that are not single day scrollers that preceed the first single day scroller
            // All single day svroll viewers must follow a naming convention; x:Name="Day<xxx>Scroller"
            for (numPreceeding = 0; numPreceeding < SVs.Count(); numPreceeding++)
            {
                if (SVs.ElementAt(numPreceeding).Name.Contains("Day"))
                    break;
            }

            // Break when i = the position of the SDV that contains the DoctorColumn in reference.
            for (singleDayColumn = 0; singleDayColumn < SVs.Count(); singleDayColumn++)
            {
                if (SVs.ElementAt(singleDayColumn).Name == SingleDayScrollViewer.Name)
                    break;
            }

            Console.WriteLine("Day Column: " + singleDayColumn);

            bindingCode += drColumn + 1;
            bindingCode += DIVM._dayCodes.ElementAt(singleDayColumn - numPreceeding);

            Console.WriteLine("Binding Code: " + bindingCode);

            if (DIVM.AVM._drScheduleMap.ContainsKey(Int32.Parse(bindingCode)))
                this.DrColumnItemsControl.ItemsSource = DIVM.AVM._drScheduleMap[Int32.Parse(bindingCode)];
            else
            {
                if (drColumn == 0)
                    this.DrColumnItemsControl.ItemsSource = DIVM.AVM.PearsonEmpty;
                else if (drColumn == 1)
                    this.DrColumnItemsControl.ItemsSource = DIVM.AVM.SpecterEmpty;
                else
                    this.DrColumnItemsControl.ItemsSource = DIVM.AVM.PaulsenEmpty;
            }
        }





        private void OnWindowResize(object sender, SizeChangedEventArgs e)
        {
            Grid drColumn = (Grid)sender;
           
            double newWidth = e.NewSize.Width;
            double newHeight = e.NewSize.Height;

            
            Console.WriteLine("WINDOW RESIZED\n");

            double columnWidth = (newWidth - 255) / 3;

            if (columnWidth >= 80)
                drColumn.ColumnDefinitions.ElementAt(0).Width = new GridLength(columnWidth);
        }


        private void OnMouseEnterAppointmentSlot(object sender, MouseEventArgs e)
        {
            Rectangle r = new Rectangle();
            TextBlock t = new TextBlock();
            Button b = new Button();

            Grid parentGrid;

            Type senderType = sender.GetType();

            if (senderType == r.GetType())
            {
                r = (Rectangle)sender;
                parentGrid = (Grid)r.Parent;
            }
            else if (senderType == t.GetType())
            {
                t = (TextBlock)sender;
                parentGrid = (Grid)t.Parent;
            }
            else
            {
                b = (Button)sender;
                parentGrid = (Grid)b.Parent;
            }



            Rectangle rectangle = parentGrid.Children.OfType<Rectangle>().ElementAt(0);
            TextBlock textBlock = parentGrid.Children.OfType<TextBlock>().ElementAt(0);


            rectangle.Opacity = 0.7;
            rectangle.RadiusX = 2;
            rectangle.RadiusY = 2;
            rectangle.StrokeThickness = 2;
            textBlock.Foreground = Brushes.BlueViolet;
        }

        private void OnMouseLeaveAppointmentSlot(object sender, MouseEventArgs e)
        {
            Rectangle r = new Rectangle();
            TextBlock t = new TextBlock();
            Button b = new Button();

            Grid parentGrid;

            Type senderType = sender.GetType();

            if (senderType == r.GetType())
            {
                r = (Rectangle)sender;
                parentGrid = (Grid)r.Parent;
            }
            else if (senderType == t.GetType())
            {
                t = (TextBlock)sender;
                parentGrid = (Grid)t.Parent;
            }
            else
            {
                b = (Button)sender;
                parentGrid = (Grid)b.Parent;
            }



            Rectangle rectangle = parentGrid.Children.OfType<Rectangle>().ElementAt(0);
            TextBlock textBlock = parentGrid.Children.OfType<TextBlock>().ElementAt(0);

            rectangle.Opacity = 0.5;
            rectangle.RadiusX = 4;
            rectangle.RadiusY = 4;
            rectangle.StrokeThickness = 1;
            textBlock.Foreground = Brushes.Black;
        }




        private void OnMouseUpAppointmentSlot(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            Rectangle apptSlot = (Rectangle)sender;
            string apptSlotID = apptSlot.Tag.ToString();


            Appointment appt = DIVM.AVM._appointmentLookup[Int32.Parse(apptSlotID)];


            // Set appointment as active appointment. AppointmentViewModel will have an Appointment object
            //      that contains information for the last clicked appointment, either in the search bar or
            //      schedule view.
            Console.WriteLine(appt.Patient);

        }




// =========================  Next three functions for drag and drop. ==================


        // Used to detect a click and drag combination
        private void OnMouseMoveAppointmentSlot(object sender, MouseEventArgs e)
        {
            Rectangle apptSlot = (Rectangle) sender;

            if (apptSlot != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(apptSlot, apptSlot.Tag.ToString(), DragDropEffects.All);
                // Refresh slot that was dragged to..
            }
        }
        
        // If there was data from the source appt slot and the target is not itself, show drag icon near mouse pointer
        private void OnDragEnterAppointmentSlot(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.StringFormat) || sender == e.Source)
                e.Effects = DragDropEffects.None;
            else
                e.Effects = DragDropEffects.All;
        }

        // Logic for when an item is dropped (mouse released after drag onto appt slot).
        private void OnDropInAppointmentSlot(object sender, DragEventArgs e)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;
            Appointment sourceAppointment;
            Appointment targetAppointment;
            string keyForSourceAppointment;
            string keyForTargetAppointment;


            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                Appointment apptFollowingTarget = null;
                Appointment apptFollowingSource = null;

                keyForSourceAppointment = (string)e.Data.GetData(DataFormats.StringFormat);
                sourceAppointment = DIVM.AVM._appointmentLookup[Int32.Parse(keyForSourceAppointment)];

                keyForTargetAppointment = ((Rectangle)sender).Tag.ToString();
                targetAppointment = DIVM.AVM._appointmentLookup[Int32.Parse(keyForTargetAppointment)];

                Console.WriteLine("Source Appointment Date: " + sourceAppointment.DateTime);
                Console.WriteLine("Target Appointment Date: " + targetAppointment.DateTime);

                if (targetAppointment.Type.Length != 0)
                    return;

                // Collapse the empty appointment following the target to make room for two appointments.
                // Expand the collapsed (by default) appointment following the source appointment.
                if (sourceAppointment.Type.Equals("Consultation"))
                {
                    apptFollowingTarget = DIVM.AVM.FindAppointmentThatFollows(targetAppointment);
                    if (apptFollowingTarget == null || apptFollowingTarget.Type.Length != 0)
                        return;
                    else
                        apptFollowingTarget.Visibility = "Collapsed";

                    // Cannot be null since every consultation has a collapsed empty appointment following it by default. \
                    apptFollowingSource = DIVM.AVM.FindAppointmentThatFollows(sourceAppointment);
                    apptFollowingSource.Visibility = "Visible";

                    targetAppointment.EndTime = targetAppointment.StartTime + 30;
                }
                else
                    targetAppointment.EndTime += 15;

                if (targetAppointment.EndTime % 100 >= 60)
                    targetAppointment.EndTime += 40;
                targetAppointment.Height = sourceAppointment.Height;
                targetAppointment.Margin = sourceAppointment.Margin;
                targetAppointment.Missed = sourceAppointment.Missed;
                targetAppointment.Opacity = sourceAppointment.Opacity;
                targetAppointment.Patient = sourceAppointment.Patient;
                targetAppointment.RowSpan = sourceAppointment.RowSpan;
                targetAppointment.Type = sourceAppointment.Type;
                targetAppointment.Waitlisted = sourceAppointment.Waitlisted;


                sourceAppointment.EndTime = sourceAppointment.StartTime + 15;
                if (sourceAppointment.EndTime % 100 >= 60)
                    sourceAppointment.EndTime += 40;
                sourceAppointment.Comments = "";
                sourceAppointment.Height = "35";
                sourceAppointment.Margin = "0,1,0,0";
                sourceAppointment.Missed = false;
                sourceAppointment.Opacity = "0";
                sourceAppointment.Patient = "";
                sourceAppointment.Type = "";
                sourceAppointment.Waitlisted = false;


            }

        }








    }
}
