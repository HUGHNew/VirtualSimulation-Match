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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private void MainResize(object sender, EventArgs e) {
            int pad = MainButtonFlowPanel.Location.X;
            this.MainButtonFlowPanel.Size = new Size(this.Width-3*pad,this.MainButtonFlowPanel.Height);
            this.MainButtonFlowPanel.Location = new Point(this.MainButtonFlowPanel.Location.X, this.Height - 2*this.MainButtonFlowPanel.Height);
        }

        private void LineAverageLay(object sender, LayoutEventArgs e) {
            int ItemsCount=MainButtonFlowPanel.Controls.Count;
            if (ItemsCount == 0) return;
            //ButtonFlowPanel.Controls[0].Width; // assume all items are the same width
            int ItemWidth = Width / (2 * ItemsCount+1);
            int NextStep = ItemWidth << 1;
            //ButtonFlowPanel.Padding= new Padding(0, 3, ItemWidth, 0);
            int originalX = MainButtonFlowPanel.Controls[0].Location.X;
            foreach(Control it in MainButtonFlowPanel.Controls){
                //it.Location = new Point(originalX, it.Location.Y);
                it.Size = new Size(ItemWidth, it.Height);
                originalX += NextStep;
                it.Margin=new Padding(ItemWidth, 0, 0, 0);
            }
        }

        private void ResizePanel(object sender, EventArgs e) {
            LineAverageLay(sender, null);
        }

        private void QAEnter(object sender, EventArgs e) {

        }
        private void MainVisible(bool hide) {
            if (hide) {
                MainButtonFlowPanel.Hide();
                QA.Hide();
            } else {
                MainButtonFlowPanel.Show();
                QA.Show();
            }
        }

        private void Content(object sender, EventArgs e) {
            SwitchForm(Status.Running);
        }
        //private void BlockListener(int milliGap,Status blockStatus,GUI.Status sub) {
        //    while (sub.GetStatus() == blockStatus) {
        //        Sleep(milliGap);
        //    }
        //}
        private void polling(object sender, EventArgs e) {
            if (Issue.GetStatus() == Status.Main) {
                this.Show();
                //Issue = new Content(Size, Location);
                //Issue.Hide();
            }
        }
        private async void BlockListener(int milliGap,Status blockStatus,GUI.Status sub) {
            while (sub.GetStatus() == blockStatus) {
                Sleep(milliGap);
            }
        }
        private void SwitchForm(Status s) {
            this.Hide();
            switch (s) {
                case Status.Running:
                    if (Issue.IsDisposed) { Issue = new Content(Size, Location); }
                    Issue.ToShow(s);break;
                default:
                    break;
            }
        }
        public enum Status {
            Running,Main,Crops,Appraisal
        };
        public void Sleep(int millisec) => System.Threading.Thread.Sleep(millisec);
        private Content Issue;
        private Timer timer;
        private void MainLoad(object sender, EventArgs e) {
            // set QA pos
            // init Issue and so on
            Issue = new Content(Size, Location);
            timer = new Timer();
            timer.Tick += polling;
            timer.Interval = 10;
            timer.Start();
        }
    }
}
