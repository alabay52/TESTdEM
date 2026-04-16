using System.Linq;
using System.Windows;
using TESTdEM.Model;

namespace TESTdEM.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                App.currentUsers = App.context.Users.FirstOrDefault(Users => Users.Login == LoginTb.Text && Users.Password == PasswordPb.Password);
                if (App.currentUsers != null)
                {
                    MessageBox.Show("Вы успешно авторизовались");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Проверьте данные");
                }
            }
        }
    }
}
