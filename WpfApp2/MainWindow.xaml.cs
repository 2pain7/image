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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            img1.Source = new BitmapImage(new Uri("http://img4-fotki.yandex.net/get/6614/39108201.e/0_STATIC89c24_345827ea_L"));
            text1.Text = "http://img4-fotki.yandex.net/get/6614/39108201.e/0_STATIC89c24_345827ea_L";
            text2.Text = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpxhere.com%2Fru%2Fphoto%2F796699&psig=AOvVaw31iLy3Elpylyqyb_04lcAX&ust=1730521716917000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCJDJ6vyluokDFQAAAAAdAAAAABAE";

        }
    }
}
