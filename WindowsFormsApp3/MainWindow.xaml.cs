using System;
using System.Linq;
using System.Windows.Forms;

namespace WpfApp2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) {
            MessageBox.Show("Button click!");
        }
    }
}
