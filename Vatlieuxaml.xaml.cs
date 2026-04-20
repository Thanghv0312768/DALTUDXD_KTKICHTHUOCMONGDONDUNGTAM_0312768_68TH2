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
using System.Windows.Shapes;

namespace giaodien0502.Views
{
    /// <summary>
    /// Interaction logic for Vatlieuxaml.xaml
    /// </summary>
    public partial class Vatlieuxaml : Window
    {
        
            public Vatlieuxaml()
            {
                InitializeComponent();
            }

            private void btnLuuVatLieu_Click(object sender, RoutedEventArgs e)
            {
                // Logic lưu dữ liệu sẽ viết ở đây
                MessageBox.Show("Đã cập nhật thông số vật liệu!");
                this.Close();
            }

            private void btnHuy_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        }
    }


