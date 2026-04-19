using System.Windows;

namespace giaodien0502.Views
{
    public partial class KichThuocMong : Window
    {
        public KichThuocMong()
        {
            InitializeComponent();
        }

        private void btnLuuKichThuoc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đã lưu kích thước móng!");
            this.Close();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}