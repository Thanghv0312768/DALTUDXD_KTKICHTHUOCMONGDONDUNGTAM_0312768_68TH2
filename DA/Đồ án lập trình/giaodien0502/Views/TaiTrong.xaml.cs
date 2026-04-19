using System.Windows;

namespace giaodien0502.Views
{
    public partial class TaiTrong : Window
    {
        public TaiTrong()
        {
            InitializeComponent();
        }

        private void btnLuuTaiTrong_Click(object sender, RoutedEventArgs e)
        {
            // Sau này bạn sẽ lấy giá trị từ các TextBox để tính toán
            // Ví dụ: double Ntc = double.Parse(txtNtc.Text);

            MessageBox.Show("Đã lưu thông số tải trọng!");
            this.Close();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}