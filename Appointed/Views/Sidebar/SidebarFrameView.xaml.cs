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
    /// Interaction logic for SidebarFrameView.xaml
    /// </summary>
    public partial class SidebarFrameView : UserControl
    {
        public SidebarFrameView()
        {
            InitializeComponent();
        }

        public void SetSidebarView(UserControl view)
        {
            SidebarGirdLayout.Children.Add(view);
            Grid.SetColumn(view, 0);
            Grid.SetRow(view, 0);
            view.VerticalAlignment = VerticalAlignment.Stretch;
            view.HorizontalAlignment = HorizontalAlignment.Stretch;
        }
    }

}
