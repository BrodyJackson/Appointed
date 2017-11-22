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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Appointed.Views;
using Appointed.Views.Sidebar;
using Appointed.Views.Dialogs;
using Appointed.ViewModels;

namespace Appointed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();


            EventManager.RegisterClassHandler
            (
                typeof(Window),
                Keyboard.KeyUpEvent,
                new KeyEventHandler(Key_Up), true
            );


  
            ShowHomeSidebar();

        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                MessageBox.Show("Delete Up!");
            }
            else if (e.Key == Key.Left)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift))
                    ShiftScheduleView(-7);
                else if (Keyboard.IsKeyDown(Key.LeftCtrl))
                    ShiftScheduleView(-3);
                else
                    ShiftScheduleView(-1);
            }
            else if (e.Key == Key.Right)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift))
                    ShiftScheduleView(7);
                else if (Keyboard.IsKeyDown(Key.LeftCtrl))
                    ShiftScheduleView(3);
                else
                    ShiftScheduleView(1);
            }
            //else if (e.Key == Key.LeftShift)
            //{
            //    ShiftScheduleView(-7);
            //}
            //else if (e.Key == Key.RightShift)
            //{
            //    ShiftScheduleView(7);
            //}
            else if (e.Key == Key.Up)
            {
            }
            else if (e.Key == Key.Down)
            {

            }
            else if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                MessageBox.Show("Enter or Return Up!");
            }
        }


   
        void ShiftScheduleView(int amount)
        {
            DayInformationViewModel DIVM = (DayInformationViewModel)this.DataContext;

            if (DIVM.ShiftView.CanExecute(null))
                DIVM.ShiftView.Execute(amount);
        }


        private void ShowHomeSidebar()
        {
            HomeSidebar homeSidebar = new HomeSidebar();

            SidebarView.SetSidebarView(homeSidebar);

        }
    }
}
