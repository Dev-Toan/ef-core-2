using QLPB.models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlctvContext context = new QlctvContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new QlctvContext()) {
                var ctv = new CongTacVien
                {
                    MaCtv = txtMaCTV.Text,
                    HoTen = txtHoTen.Text,
                    SoBv = int.Parse(txtSoBaiViet.Text),
                    MaPhong = (cbPhongBan.SelectedItem as ComboBoxItem).Tag.ToString(),
                };

                context.CongTacViens.Add(ctv);
                context.SaveChanges();
            }
            LoadData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var timm = context.CongTacViens.Where(mp => mp.MaPhong =="P01").Select(mp => new
            {
                mp.MaCtv,
                mp.HoTen,
                mp.SoBv,
                mp.MaPhong,
                mp.MaPhongNavigation.TenPhong,
                tien = 300000 * mp.SoBv,

            }).ToList();

            Window1 window1 = new Window1(timm);
            window1.Show();
        }

        private void LoadData()
        {
            var data = context.CongTacViens.Select(ctv => new
            {
                ctv.MaCtv,
                ctv.HoTen,
                ctv.SoBv,
                ctv.MaPhongNavigation.TenPhong,

                tien = 300000 * ctv.SoBv,
            }).ToList();

            dgQLCTV.ItemsSource = data;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}