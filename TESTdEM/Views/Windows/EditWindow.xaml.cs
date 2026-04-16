using System.Windows;
using TESTdEM.Model;

namespace TESTdEM.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private readonly Tariff _currentTariff;
        public EditWindow(Tariff selectedTariff)
        {
            InitializeComponent();
            _currentTariff = selectedTariff;
            DataContext = _currentTariff;
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
