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

namespace taogiaodien1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Tính toán
        private void btnTinh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ giao diện (Chuyển từ Text sang Double)
                double N = double.Parse(txtN.Text);       // Tải trọng đứng
                double R = double.Parse(txtR.Text);       // Cường độ đất nền
                double h = double.Parse(txth.Text);       // Chiều sâu chôn móng
                double gammaTB = 20.0;                    // Trọng lượng riêng TB của móng và đất (thường lấy 20kN/m3)

                // 2. Công thức tính diện tích móng đơn đúng tâm sơ bộ
                // Công thức: F >= N / (R - gammaTB * h)
                double mauSo = R - (gammaTB * h);

                if (mauSo <= 0)
                {
                    MessageBox.Show("Cường độ đất nền quá yếu hoặc chiều sâu h quá lớn!", "Lỗi thông số");
                    return;
                }

                double Fp = N / mauSo;
                double canhMóng = Math.Sqrt(Fp); // Giả sử móng vuông

                // 3. Hiển thị kết quả ra các TextBlock/Label
                lblFp.Text = $"{Fp:F2} m²";
                lblCanh.Text = $"{canhMóng:F2} m";

                // Gợi ý làm tròn (Thường móng sẽ làm tròn lên bội số của 10cm hoặc 5cm)
                double canhLamTron = Math.Ceiling(canhMóng * 10) / 10;
                MessageBox.Show($"Diện tích cần thiết là {Fp:F2} m2.\nBạn nên chọn cạnh móng tối thiểu: {canhLamTron} m", "Kết quả tính");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng chỉ nhập số vào các ô dữ liệu!", "Lỗi nhập liệu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}