﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private void MainResize(object sender, EventArgs e) {
            int pad = MainButtonFlowPanel.Location.X;
            this.MainButtonFlowPanel.Size = new Size(this.Width - 3 * pad, this.MainButtonFlowPanel.Height);
            this.MainButtonFlowPanel.Location = new Point(this.MainButtonFlowPanel.Location.X, this.Height - 2 * this.MainButtonFlowPanel.Height);
        }

        private void LineAverageLay(object sender, LayoutEventArgs e) {
            int ItemsCount = MainButtonFlowPanel.Controls.Count;
            if (ItemsCount == 0) return;
            //ButtonFlowPanel.Controls[0].Width; // assume all items are the same width
            int ItemWidth = Width / (2 * ItemsCount + 1);
            int NextStep = ItemWidth << 1;
            //ButtonFlowPanel.Padding= new Padding(0, 3, ItemWidth, 0);
            int originalX = MainButtonFlowPanel.Controls[0].Location.X;
            foreach (Control it in MainButtonFlowPanel.Controls) {
                //it.Location = new Point(originalX, it.Location.Y);
                it.Size = new Size(ItemWidth, it.Height);
                originalX += NextStep;
                it.Margin = new Padding(ItemWidth, 0, 0, 0);
            }
        }

        private void ResizePanel(object sender, EventArgs e) {
            LineAverageLay(sender, null);
        }

        private void QAEnter(object sender, EventArgs e) {
            SwitchForm(Status.Running);
        }

        //private void BlockListener(int milliGap,Status blockStatus,GUI.Status sub) {
        //    while (sub.GetStatus() == blockStatus) {
        //        Sleep(milliGap);
        //    }
        //}

        /// <param name="need_status"></param>
        /// <returns>the form relevant to status or new one if disposed
        /// null if it's Main
        /// </returns>
        private IVEInter GetAvailableForm(Status need_status,bool newForm=true) {
            switch (need_status) {
                case Status.Issue:
                    if (Issue.IsDisposed&&newForm) { Issue = new Content(); }
                    return Issue;
                case Status.Appraisal:
                    if (app.IsDisposed && newForm) { app = new Appraisal(); }
                    return app;
                case Status.Crops:
                    if (app.IsDisposed && newForm) { app = new Appraisal(); }
                    return crops;
                case Status.Running:
                    if (board.IsDisposed && newForm) { board = new QuestionBoard(); }
                    return board;
                default:
                    return null;
            }
        }
        private void Polling(object sender, EventArgs e) {
            Status next; // if subform is on
            IVEInter inter = GetAvailableForm(CurrentForm,false);
            if (inter != null) {
                LastLoc = (inter as Form).Location;
                next = inter.GetStatus();
#if DEBUG
                Console.WriteLine($"Current:{CurrentForm} next:{next}");
#endif
                if (next == Status.Main) {
                    Location = LastLoc;
                    CurrentForm = next;
                    this.Show(); return;
                } else if (next != inter.OnStatus()) {
                    // this form may be disposed
                    GetAvailableForm(next);
                    // jump to another sub form
                    SwitchForm(next);
                }
            } else {
                //if (!Visible) { this.Show();MessageBox.Show("Not Visible"); }
                // seems it can't reach here
            }
        }
        private void SwitchForm(Status s) {
            this.Hide();
            CurrentForm = s;
            IVEInter form = GetAvailableForm(s);
            if (form != null) {
                form.ToShow(Location);
            }
        }
        public enum Status {
            Running, // experimental status
            Main, // main page
            Crops, // anatomy
            Appraisal, // 
            Issue, // case details
            //Content
        };
        public void Sleep(int millisec) => System.Threading.Thread.Sleep(millisec);
        private Content Issue;
        private Appraisal app;
        private Crops crops;
        private QuestionBoard board;
        //private IVEInter[] forms; // to think about
        private Timer timer;
        private Point LastLoc;
        private Status CurrentForm = Status.Main;
        public const string Experiment = "体位性窒息法医学鉴定虚拟仿真实验";
        public const string ExitTips = "是否退出"+Experiment+"?";
        
        private void MainLoad(object sender, EventArgs e) {
            // set QA pos
            // init Issue and so on
            Issue = new Content();
            app = new Appraisal();
            crops = new Crops();
            board = new QuestionBoard();
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

        private void ExProcessClick(object sender, EventArgs e) {
            SwitchForm(Status.Issue);
        }
    }
}
