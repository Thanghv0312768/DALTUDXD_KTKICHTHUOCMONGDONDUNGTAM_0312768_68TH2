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
    /// Interaction logic for diachat.xaml
    /// </summary>
    public partial class diachat : Window
    {
        public diachat()
        {
            InitializeComponent();
        }
        private void btnDiaChat_Click(object sender, RoutedEventArgs e)
        {
            diachat wd = new diachat();
            wd.ShowDialog();
        }
        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dữ liệu đã được ghi nhận.");
            this.Close();
        }
    }

}
