using Appointed.Views.Sidebar;
using System.Windows;
using System.Windows.Controls;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for HomeTabView.xaml
    /// </summary>
    public partial class HomeSidebar : UserControl
    {
        public HomeSidebar()
        {
            InitializeComponent();

            SearchInput.Search += SearchInput_Search;

            //AlertBox.AddAlert(new Classes.Alert() { ButtonText = "Reschedule", Title = "Appt. Bump Available for Mike Ross" });
            //AlertBox.AddAlert(new Classes.Alert() { ButtonText = "Reschedule", Title = "Jerry Sienfeld Missed Appointment" });
            //AlertBox.AddAlert(new Classes.Alert() { ButtonText = "Reschedule", Title = "Arnold P. Jenkins Missed Appointment" });

            //AlertBox.UpdateAlertsBox();

            Loaded += HomeSidebar_Loaded;

        }

        //Gross work-around for going back to home sidebar from search results
        private void HomeSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            SearchInput.InputField.TextField.Text = "";
            SearchInput.InputField.ShowHintText(SearchInput.InputField.TextField);
        }

        private void SearchInput_Search(object sender, System.EventArgs e)
        {
            Home home = App.Current.MainWindow as Home;

            home.SidebarView.SetSidebarView(new SearchResultsSidebar(SearchInput.InputField.TextField.Text));
        }
    }
}
