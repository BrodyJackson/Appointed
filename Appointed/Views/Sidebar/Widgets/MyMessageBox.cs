﻿using Appointed.Classes;
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

namespace Appointed.Views.Sidebar.Widgets
{

    // For single button messages with no action taken on the user's choice
    // MyMessageBox msgBox = new MyMessageBox();
    // msgBox.Show
    // (
    //    "The time slot specified is taken!",
    //    "Unable to Modify Appointment",
    //    MyMessageBox.Button.Ok
    // );



    // An example of an event handler "OnMouseLeftRelease_Discard" using a message box to request user confirmation.
    // The handler "OnDiscardConfirmation" is subscribed to the "msgBox.MessageBoxResult" event.
    // When the user makes a choice, the event is raised and their choice is forwarded in a MessageBoxEventArgs object.

    // private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
    // {
    //    MyMessageBox msgBox = new MyMessageBox();
    //
    //    msgBox.MessageBoxResult += OnDiscardConfirmation;
    //
    //    msgBox.Show
    //        (
    //            "Are you sure you wish to discard your changes?",
    //            "Confirm Selection",
    //            MyMessageBox.Button.Yes,
    //            MyMessageBox.Button.No
    //        );
    // }

    // private void OnDiscardConfirmation(object sender, MessageBoxEventArgs e)
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
        // It provides MessageBoxEventArgs which contain a member of the Result enumeration.
        public event EventHandler<MessageBoxEventArgs> MessageBoxResult;

        private Popup popup;

        private Button leftBtn;
        private Button rightBtn;

        private Result r = Result.NotSelected;

        public enum Result { Yes, No, Ok, Cancel, Save, Discard, NotSelected };
        public enum Button { Yes, No, Ok, Cancel, Save, Discard };


        double opacity = 0.3;


        public MyMessageBox()
        {
        }

        

        // Two Button Popup
        public void Show(string mssg, string title, Button left, Button right)
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

            m.RightButton.Click += OnRightButtonClick;
            m.LeftButton.Click += OnLeftButtonClick;
        }

        


        // One Button Popup
        public void Show(string mssg, string title, Button btn)
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

            m.Button.Click += OnLeftButtonClick;
        }




        


        // Private delegates
        private void OnRightButtonClick(object sender, RoutedEventArgs e)
        {
            r = getResult(rightBtn);
            MessageBoxResult?.Invoke(this, new MessageBoxEventArgs { result = r });

            popup.StaysOpen = false;
            popup.IsOpen = false;

            Application.Current.MainWindow.OpacityMask = null;
            Application.Current.MainWindow.Opacity = 1.0;
            Application.Current.MainWindow.IsHitTestVisible = true;
        }


        private void OnLeftButtonClick(object sender, RoutedEventArgs e)
        {
            r = getResult(leftBtn);
            MessageBoxResult?.Invoke(this, new MessageBoxEventArgs { result = r });

            popup.StaysOpen = false;
            popup.IsOpen = false;

            Application.Current.MainWindow.OpacityMask = null;
            Application.Current.MainWindow.Opacity = 1.0;
            Application.Current.MainWindow.IsHitTestVisible = true;
        }




        private Result getResult(Button b)
        {
            Result r;

            switch (b)
            {
                case Button.Yes:
                    r = Result.Yes;
                    break;
                case Button.No:
                    r = Result.No;
                    break;
                case Button.Ok:
                    r = Result.Ok;
                    break;
                case Button.Cancel:
                    r = Result.Cancel;
                    break;
                case Button.Save:
                    r = Result.Save;
                    break;
                case Button.Discard:
                    r = Result.Discard;
                    break;
                default:
                    r = Result.NotSelected;
                    break;
            };

            return r;
        }

        
        private string getContent(Button b)
        {
            string content;

            switch (b)
            {
                case Button.Yes:
                    content = "Yes";
                    break;
                case Button.No:
                    content = "No";
                    break;
                case Button.Ok:
                    content = "Ok";
                    break;
                case Button.Cancel:
                    content = "Cancel";
                    break;
                case Button.Save:
                    content = "Save";
                    break;
                case Button.Discard:
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
