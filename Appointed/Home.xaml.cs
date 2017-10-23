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

            SidebarView.SetSidebarView(new HomeSidebar());

            //TODO: Replace these icons with black versions

            Button newApptBtn = new Button
            {
                Content = new Image()
                {
                    Source = new BitmapImage(new Uri("pack://application:,,,/Appointed;component/imgs/NewApptIcon.png")),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };

            Button newPatientBtn = new Button
            {
                Content = new Image()
                {
                    Source = new BitmapImage(new Uri("pack://application:,,,/Appointed;component/imgs/PatientIcon.png")),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };

            SidebarView.SetLeftQuickNavButton(newApptBtn);
            SidebarView.SetRightQuickNavButton(newPatientBtn);

            //TODO: Add event listeners
        }

    }
}
