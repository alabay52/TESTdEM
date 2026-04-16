using System.Windows;
using TESTdEM.Model;

namespace TESTdEM
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DriftRentSochnev1Entities context = new DriftRentSochnev1Entities();
        public static Users currentUsers { get; set; }
    }
}
