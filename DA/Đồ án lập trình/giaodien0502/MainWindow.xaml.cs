using giaodien0502.models;
using giaodien0502.Views; // QUAN TRỌNG: Dòng này để gọi được file diachat
using System;
using System.Windows;

namespace giaodien0502
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 1. Nút Địa chất (Dòng 32 bên XAML)
        private void btnDiaChat_Click(object sender, RoutedEventArgs e)
        {
            diachat wd = new diachat();
            wd.ShowDialog();
        }

        // 2. Nút Vật liệu
        private void btnVatLieu_Click(object sender, RoutedEventArgs e)
        {
            Vatlieuxaml vl = new Vatlieuxaml();
            vl.ShowDialog();
        }

        // 3. Nút Tải trọng
        private void btnTaiTrong_Click(object sender, RoutedEventArgs e)
        {
            TaiTrong tt = new TaiTrong();
            tt.ShowDialog();
        }

        // 4. Nút Kích thước
        private void btnKichThuoc_Click(object sender, RoutedEventArgs e)
        {
            KichThuocMong kt = new KichThuocMong();
            kt.ShowDialog();
        }
    }
}