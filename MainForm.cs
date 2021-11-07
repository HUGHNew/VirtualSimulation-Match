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

        //private void BlockListener(int milliGap,Status blockStatus,GUI.Status sub) {
        //    while (sub.GetStatus() == blockStatus) {
        //        Sleep(milliGap);
        //    }
        //}
        private void Polling(object sender, EventArgs e) {
            IVEInter inter=null;
            Status next; // if subform is on
            switch (CurrentForm) {
                case Status.Issue:
                    inter = Issue;
                    LastLoc = Issue.Location;break;
                case Status.Appraisal:
                    inter = app;
                    LastLoc = app.Location;break;
                case Status.Crops:
                    inter = crops;
                    LastLoc = crops.Location;break;
                default:
                    // main
                    return;
            }
            if (inter != null) {
                next = inter.GetStatus();
                if (next == Status.Main) {
                    CurrentForm = Status.Main;
                    Location = LastLoc;
                    this.Show(); return;
                }else if (next != inter.OnStatus()) {
                    // jump to another sub form
                    SwitchForm(next);
                }
            }
        }
        private void SwitchForm(Status s) {
            this.Hide();
            CurrentForm = s;
            IVEInter form=null;
            switch (s) {
                case Status.Issue:
                    if (Issue.IsDisposed) { Issue = new Content(); }
                    form =Issue; break;
                case Status.Appraisal:
                    if (app.IsDisposed) { app = new Appraisal(); }
                    form=app; break;
                case Status.Crops:
                    if (app.IsDisposed) { app = new Appraisal(); }
                    form = crops;break;
                case Status.Running:
                    break;
                default:
                    break;
            }
            (form as Form).Location = Location;
            form.ToShow();
        }
        public enum Status {
            Running, // experimental status
            Main, // main page
            Crops, // anatomy
            Appraisal, // 
            Issue // case details
        };
        public void Sleep(int millisec) => System.Threading.Thread.Sleep(millisec);
        private Content Issue;
        private Appraisal app;
        private Crops crops;
        private IVEInter[] forms; // to think about
        private Timer timer;
        private Point LastLoc;
        private Status CurrentForm=Status.Main;
        private void MainLoad(object sender, EventArgs e) {
            // set QA pos
            // init Issue and so on
            Issue = new Content();
            app = new Appraisal();
            crops = new Crops();
            timer = new Timer();
            timer.Tick += Polling;
            timer.Interval = 10;
            timer.Start();
        }
        private void Content(object sender, EventArgs e) {
            SwitchForm(Status.Issue);
        }

        private void AppStart(object sender, EventArgs e) {
            SwitchForm(Status.Appraisal);
        }

        private void CropsJump(object sender, EventArgs e) {
            SwitchForm(Status.Crops);
        }
    }
}
