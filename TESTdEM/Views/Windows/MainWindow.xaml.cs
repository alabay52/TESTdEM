using System.Linq;
using System.Windows;
using TESTdEM.Model;
using TESTdEM.Views.Windows;

namespace TESTdEM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void AddBtm_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            if (addWindow.ShowDialog() == true)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            TariffLv.ItemsSource = App.context.Tariff.ToList();
        }
        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            Tariff selectedTariff = TariffLv.SelectedItem as Tariff;
            if (TariffLv.SelectedItem != null)
            {




                try
                {
                    App.context.Tariff.Remove(selectedTariff);
                    App.context.SaveChanges();
                    MessageBox.Show("Удалено");
                    LoadData();

                }
                catch
                {
                    MessageBox.Show("Невозможно удалить тариф");
                }

            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

            Tariff selectedTariff = TariffLv.SelectedItem as Tariff;
            if (selectedTariff != null)
            {
                EditWindow editWindow = new EditWindow(selectedTariff);
                editWindow.ShowDialog();

            }
            else
            {
                MessageBox.Show("Выберите тариф");
            }


        }
    }
}
