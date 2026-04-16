using System;
using System.Windows;
using TESTdEM.Model;

namespace TESTdEM.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditWindows.xaml
    /// </summary>
    public partial class AddEditWindows : Window
    {
        private readonly Tariff _currentTariff;
        public AddEditWindows()
        {
            InitializeComponent();
            AddBtn.Visibility = Visibility.Visible;
            Editbtn.Visibility = Visibility.Collapsed;
        }
        public AddEditWindows(Tariff selectedTariff)
        {
            InitializeComponent();
            _currentTariff = selectedTariff;
            AddBtn.Visibility = Visibility.Collapsed;
            Editbtn.Visibility = Visibility.Visible;
            DataContext = _currentTariff;
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Tariff tariff = new Tariff()
            {
                Name = NameTb.Text,
                Price = Convert.ToInt32(PriceTb.Text),
                Description = DescriptionTb.Text,
            };
            App.context.Tariff.Add(tariff);
            App.context.SaveChanges();
            MessageBox.Show("Тариф добавлен");
            DialogResult = true;
        }
    }
}
