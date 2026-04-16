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
            AddEditWindows addEditWindows = new AddEditWindows();
            if (addEditWindows.ShowDialog() == true)
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
            if (TariffLv.SelectedItem != null)
            {
                Tariff selectedTariff = TariffLv.SelectedItem as Tariff;



                try
                {
                    App.context.Tariff.Remove(selectedTariff);
                    App.context.SaveChanges();
                    MessageBox.Show("Удалено");
                    LoadData();

                }
                catch
                {
                    MessageBox.Show("Невозможно удалить компанию");
                }

            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Tariff selectedTariff = TariffLv.SelectedItem as Tariff;
            if (selectedTariff != null)
            {
                AddEditWindows editWindows = new AddEditWindows(selectedTariff);
                editWindows.ShowDialog();
            }
            else
            {
                MessageBox.Show("Сначала выберите компанию");
            }
        }
    }
}
