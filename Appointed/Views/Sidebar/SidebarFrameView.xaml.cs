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
        Button _leftQuickNavButton;
        Button _rightQuickNavButton;
        UserControl _sidebarView;

        public SidebarFrameView()
        {
            InitializeComponent();
        }

        public UserControl GetSidebarView()
        {
            return _sidebarView;
        }

        public void SetSidebarView(UserControl view)
        {
            SidebarGridLayout.Children.Remove(_sidebarView);
            _sidebarView = view;
            SidebarGridLayout.Children.Add(view);
            Grid.SetColumn(view, 0);
            Grid.SetRow(view, 0);
            view.VerticalAlignment = VerticalAlignment.Stretch;
            view.HorizontalAlignment = HorizontalAlignment.Stretch;
        }

        /// <summary>
        /// Replaces the left Quick Nav Button.
        /// > Will rename button to "LeftQuickNavButton"
        /// </summary>
        /// <param name="btn">Button to replace left quick nav button</param>
        public void SetLeftQuickNavButton(Button btn)
        {
            QuickNavArea.Children.Remove(LeftQuickNavButton);
            if (btn != null)
            {
                btn.Name = "LeftQuickNavButton";
                QuickNavArea.Children.Add(btn);
                Grid.SetColumn(btn, 0);
                Grid.SetRow(btn, 0);
            }
            _leftQuickNavButton = btn;
        }

        /// <summary>
        /// Replaces the Right Quick Nav Button.
        /// > Will rename button to "RightQuickNavButton"
        /// </summary>
        /// <param name="btn">Button to replace Right quick nav button</param>
        public void SetRightQuickNavButton(Button btn)
        {
            QuickNavArea.Children.Remove(LeftQuickNavButton);
            if (btn != null)
            {
                btn.Name = "RightQuickNavButton";
                QuickNavArea.Children.Add(btn);
                Grid.SetColumn(btn, 1);
                Grid.SetRow(btn, 0);
            }
            _rightQuickNavButton = btn;
        }

        public Button GetLeftQuickNavButton()
        {
            return _leftQuickNavButton;
        }

        public Button GetRightQuickNavButton()
        {
            return _rightQuickNavButton;
        }

    }

}
