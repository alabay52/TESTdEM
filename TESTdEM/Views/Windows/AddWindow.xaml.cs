using System;
using System.Windows;
using TESTdEM.Model;

namespace TESTdEM.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
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
