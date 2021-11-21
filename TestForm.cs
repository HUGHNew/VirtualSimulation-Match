using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class TestForm : Form {
        public TestForm() {
            InitializeComponent();
        }

        private void label1_Resize(object sender, EventArgs e) {

        }
        Random random = new Random();
        private void label1_Click(object sender, EventArgs e) {
            Size = new Size(random.Next(100, 300), random.Next(100, 300));
        }
        int times = 0;
        private void label1_Resize_1(object sender, EventArgs e) {

        }
    }
}
