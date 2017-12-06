using Appointed.Classes;
using Appointed.Views.Sidebar.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Appointed.Classes
{

    // For single button messages  - informative messages
    // MyMessageBox msgBox = new MyMessageBox();
    // msgBox.Show
    // (
    //    "The time slot specified is taken!",
    //    "Unable to Modify Appointment",
    //    MyMessageBox.Button.Ok
    // );


    // For two button messages - choices or confirmations
    // An example of an event handler "OnMouseLeftRelease_Discard" using a message box to request user confirmation.
    // The handler "OnChoiceMade" is subscribed to the "msgBox.MessageBoxResult" event.
    // When the user makes a choice, the event is raised and their choice is forwarded in a MessageBoxEventArgs object.

    // private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
    // {
    //    MyMessageBox msgBox = new MyMessageBox();
    //
    //    msgBox.MessageBoxResult += OnChoiceMade;
    //
    //    msgBox.Show
    //        (
    //            "Are you sure you wish to discard your changes?",
    //            "Confirm Selection",
    //            MyMessageBox.Button.Yes,
    //            MyMessageBox.Button.No
    //        );
    // }

    // private void OnChoiceMade(object sender, MessageBoxEventArgs e)
    // {
    //    MyMessageBox.Result r = e.result;
    //
    //    if (r == MyMessageBox.Result.Yes)
    //    {
    //        Home h = App.Current.MainWindow as Home;
    //        h.SidebarView.SetSidebarView(new AppointmentDetailsSidebar());
    //    }
    // }

        
    public class MyMessageBox
    {
        // An event that is raised when a message box button is clicked.
        // It provides an object of class MessageBoxEventArgs which contains a member of the Result enumeration.
        public event EventHandler<MessageBoxEventArgs> MessageBoxResult;

        private Popup popup;

        private Buton leftBtn;
        private Buton rightBtn;

        private Result r = Result.NotSelected;

        public enum Result { Yes, No, Ok, Cancel, Save, Discard, NotSelected };
        public enum Buton { Yes, No, Ok, Cancel, Save, Discard };


        double opacity = 0.3;


        public MyMessageBox()
        {
        }
        

        // Two Button Popup
        public void Show(string mssg, string title, Buton left, Buton right)
        {
            MessageBoxLayoutTwoButton m = new MessageBoxLayoutTwoButton();

            m.Title.Text = title;
            m.Message.Text = mssg;
            m.LeftButton.Content = getContent(left);
            m.RightButton.Content = getContent(right);
            leftBtn = left;
            rightBtn = right;

            popup = new Popup
            {
                Child = m,
                StaysOpen = true,
                AllowsTransparency = true,
                Placement = PlacementMode.Center,
                PlacementTarget = App.Current.MainWindow,
            };
            
            Application.Current.MainWindow.OpacityMask = Brushes.Black;
            Application.Current.MainWindow.Opacity = opacity;
            Application.Current.MainWindow.IsHitTestVisible = false;

            popup.IsOpen = true;
            popup.BringIntoView();

            m.RightButton.Click += OnButtonClick;
            m.LeftButton.Click += OnButtonClick;
        }

        


        // One Button Popup
        public void Show(string mssg, string title, Buton btn)
        {
            MessageBoxLayoutOneButton m = new MessageBoxLayoutOneButton();

            m.Title.Text = title;
            m.Message.Text = mssg;
            m.Button.Content = getContent(btn);
            leftBtn = btn;

            popup = new Popup
            {
                Child = m,
                StaysOpen = true,
                AllowsTransparency = true,
                Placement = PlacementMode.Center,
                PlacementTarget = App.Current.MainWindow,
            };

            Application.Current.MainWindow.OpacityMask = Brushes.Black;
            Application.Current.MainWindow.Opacity = opacity;
            Application.Current.MainWindow.IsHitTestVisible = false;

            popup.IsOpen = true;
            popup.BringIntoView();

            m.Button.Click += OnButtonClick;
        }



        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Button b = sender as Button;

            if (b.Name == "LeftButton" || b.Name == "Button")
                r = getResult(leftBtn);
            else if (b.Name == "RightButton")
                r = getResult(rightBtn);

            MessageBoxResult?.Invoke(this, new MessageBoxEventArgs { result = r });

            popup.StaysOpen = false;
            popup.IsOpen = false;

            Application.Current.MainWindow.OpacityMask = null;
            Application.Current.MainWindow.Opacity = 1.0;
            Application.Current.MainWindow.IsHitTestVisible = true;
        }


        private Result getResult(Buton b)
        {
            Result r;

            switch (b)
            {
                case Buton.Yes:
                    r = Result.Yes;
                    break;
                case Buton.No:
                    r = Result.No;
                    break;
                case Buton.Ok:
                    r = Result.Ok;
                    break;
                case Buton.Cancel:
                    r = Result.Cancel;
                    break;
                case Buton.Save:
                    r = Result.Save;
                    break;
                case Buton.Discard:
                    r = Result.Discard;
                    break;
                default:
                    r = Result.NotSelected;
                    break;
            };

            return r;
        }

        
        private string getContent(Buton b)
        {
            string content;

            switch (b)
            {
                case Buton.Yes:
                    content = "Yes";
                    break;
                case Buton.No:
                    content = "No";
                    break;
                case Buton.Ok:
                    content = "Ok";
                    break;
                case Buton.Cancel:
                    content = "Cancel";
                    break;
                case Buton.Save:
                    content = "Save";
                    break;
                case Buton.Discard:
                    content = "Discard";
                    break;
                default:
                    content = "Maybe";
                    break;
            };

            return content;
        }


    }
}
