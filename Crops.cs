using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class Crops : Form, IVEInter {
        public Crops() {
            InitializeComponent();
        }
        #region Panels Layout and Resize
        private void PanelLayout(Panel p, bool TopDown) {
            int width = p.Width - 4;
            int height = p.Height / (p.Controls.Count + 1);
            int pad_bottom = height / p.Controls.Count;
            Size CltSize = new Size(width, height);
            int yAxis, delta = height + pad_bottom;
            if (TopDown) {
                p.Padding = new Padding(1, 0, 1, pad_bottom);
                yAxis = p.Location.Y;
            } else {
                delta = -delta;
                p.Padding = new Padding(1, pad_bottom, 1, 0);
                yAxis = p.Location.Y + p.Height;
            }
            foreach (Control it in p.Controls) {
                it.Size = CltSize;
                it.Location = new Point(p.Location.X, yAxis);
                yAxis += delta;
            }
        }

        private void ItemLayout(object sender, LayoutEventArgs e) {
            PanelLayout(ItemFlow, true);
        }

        private void ItemResize(object sender, EventArgs e) {
            PanelLayout(ItemFlow, true);
        }

        private void MenuResize(object sender, EventArgs e) {
            PanelLayout(MenuFlow, false);
        }

        private void MenuLayout(object sender, LayoutEventArgs e) {
            PanelLayout(MenuFlow, false);
        }
        #endregion
        private void TextLoad(object sender, EventArgs e) {
            //MessageBox.Show(Properties.Resources.post_mortem);
            status = MainForm.Status.Crops;
            Contents[0] = Properties.Resources.post_mortem;
            Contents[1] = Properties.Resources.organ;
            Contents[2] = Properties.Resources.tissue;
            Contents[3] = Properties.Resources.drug;
            Contents[4] = Properties.Resources.pathology;
            Contents[5] = Properties.Resources.analysis;
            RichText_Tbox.Text = Contents[0];
        }
        private readonly string[] Contents = new string[6];
        private MainForm.Status status;
        private void ShowContent(int index) {
            RichText_Tbox.Text = Contents[index];
        }

        public MainForm.Status GetStatus() => status;

        public MainForm.Status OnStatus() => MainForm.Status.Crops;

        public void ToShow() {
            status = OnStatus();
            this.Show();
        }
        private static int BtnText2Idx(string text) {
            switch (text) {
                case "尸体检验": return 0;
                case "器官检验": return 1;
                case "组织检查": return 2;
                case "毒物分析": return 3;
                case "病理诊断": return 4;
                case "分析说明": return 5;
                default: return 0;
            }
        }
        private void Btn_Click(object sender, EventArgs e) {
            ShowContent(BtnText2Idx((sender as Button).Text));
        }


        protected void CloseAction(object sender, FormClosedEventArgs e) {
            ReturnProc(MainForm.Status.Main);
        }
        protected void ReturnProc(MainForm.Status s) {
            this.Hide();
            status = s;
        }

        private void Return(object sender, EventArgs e) {
            ReturnProc(MainForm.Status.Main);
        }
        private void JumpAppraisal(object sender, EventArgs e) {
            ReturnProc(MainForm.Status.Appraisal);
        }

        private void JumpExperiment(object sender, EventArgs e) {
            ReturnProc(MainForm.Status.Running);
        }
    }
}
