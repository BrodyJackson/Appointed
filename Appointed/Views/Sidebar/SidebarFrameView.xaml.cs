using Appointed.Views.Dialogs;
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
    /// Interaction logic for SidebarFrameView.xaml
    /// </summary>
    public partial class SidebarFrameView : UserControl
    {
        Button _leftQuickNavButton;
        Button _rightQuickNavButton;
        UserControl _sidebarView;

        public Stack<UserControl> _sidebarHistory = new Stack<UserControl>();

        public SidebarFrameView()
        {
            InitializeComponent();
        }

        public UserControl GetSidebarView()
        {
            return _sidebarView;
        }

        /// <summary>
        /// Used to change sidebar view.
        /// Set pushToHistoryStack to false to avoid infinite loops. (Whenever using the back button, set push to false)
        /// </summary>
        /// <param name="view">new view to set sidebar to</param>
        /// <param name="pushToHistoryStack"> Defaults to true, if false the current view will not be pushed to the history stack</param>
        public void SetSidebarView(UserControl view, bool pushToHistoryStack = true)
        {
            if(pushToHistoryStack)
            {
                _sidebarHistory.Push(_sidebarView);
            }
            
               
            SidebarGridLayout.Children.Remove(_sidebarView);
            _sidebarView = view;
            SidebarGridLayout.Children.Add(view);
            Grid.SetColumn(view, 0);
            Grid.SetRow(view, 0);
            view.VerticalAlignment = VerticalAlignment.Stretch;
            view.HorizontalAlignment = HorizontalAlignment.Stretch;

            //Auto set buttons based on special case for the home view, all other sidebars should have standard back/home buttons
            if(view is HomeSidebar)
            {
                //Clear history stack
                _sidebarHistory.Clear();
                SetHomeSidebarQuickNavButtons();
            }
            else
            {
                SetStandardQuickNavButtons();
            }

        }

        

        private void SetStandardQuickNavButtons()
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            Button homeButton = new Button
            {
                Content = new Image()
                {
                    Source = Assets.ResourceManager.Instance.Images["HomeIcon"],
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };

            Button backButton = new Button
            {
                Content = new Image()
                {
                    Source = Assets.ResourceManager.Instance.Images["ReturnIcon"],
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };

            SetLeftQuickNavButton(backButton);
            SetRightQuickNavButton(homeButton);

            backButton.Click += (object s, RoutedEventArgs args) =>
            {
                GetConfirmation(false);
            };

            homeButton.Click += (object s, RoutedEventArgs args) =>
            {
                GetConfirmation(true);
            };
        }

        private void SetHomeSidebarQuickNavButtons()
        {
            Button newPatientBtn = new Button
            {
                Content = new Image()
                {
                    Source = Assets.ResourceManager.Instance.Images["NewPatientIcon"],
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(8d)
                }
            };

            SetLeftQuickNavButton(newPatientBtn);
            SetRightQuickNavButton(null);
            Grid.SetColumnSpan(newPatientBtn, 2);

            newPatientBtn.Click += (object sender, RoutedEventArgs args) => { new NewPatientDialog().ShowDialog(); };
        }

        public UserControl GetPreviousSidebar()
        {
            if (_sidebarHistory.Count > 0)
                return _sidebarHistory.Pop();
            else
                return this;
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


        private void GetConfirmation(bool goHome)
        {
            Home h = App.Current.MainWindow as Home;
            
            if (h.SidebarView.GetSidebarView() is AppointmentDetailsSidebar || 
                h.SidebarView.GetSidebarView() is Sidebar.SearchResultsSidebar ||
                (h.SidebarView.GetSidebarView() is Sidebar.PatientInfoSidebar && !(h.SidebarView.GetSidebarView() as Sidebar.PatientInfoSidebar).HasChanges()))
            {
                OnHomeConfirmation(this, new MessageBoxEventArgs { result = MyMessageBox.Result.Yes });
                return;
            }

            MyMessageBox msgBox = new MyMessageBox();

            if (goHome)
                msgBox.MessageBoxResult += OnHomeConfirmation;
            else
                msgBox.MessageBoxResult += OnBackConfirmation;

            msgBox.Show
                (
                    "Are you sure you wish to discard your changes?",
                    "Confirm Selection",
                    MyMessageBox.Buton.Yes,
                    MyMessageBox.Buton.No
                );

            return;
        }

        private void OnHomeConfirmation(object sender, MessageBoxEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            MyMessageBox.Result r = e.result;

            if (r == MyMessageBox.Result.Yes)
            {
                DIVM.ResetHighlightedAppointment();
                SetSidebarView(new HomeSidebar());
            }
        }

        private void OnBackConfirmation(object sender, MessageBoxEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            MyMessageBox.Result r = e.result;

            if (r == MyMessageBox.Result.Yes)
            {
                DIVM.ResetHighlightedAppointment();
                SetSidebarView(GetPreviousSidebar(), false);
            }
        }

    }

}
