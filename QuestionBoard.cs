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
    public partial class QuestionBoard : Form,IVEInter {
        public QuestionBoard() {
            InitializeComponent();
        }
        private const uint MaxIdx = 1;
        private readonly VariableRadioPanel[] Options=new VariableRadioPanel[MaxIdx];
        private readonly IQTag[] Themes=new IQTag[MaxIdx];
        private readonly IQTag EmptyTag = new Q1();
        private readonly Control[] ThemeControl= new Control[3];
        private uint Index = 0;
        private MainForm.Status status;
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        #region Interface implement
        public MainForm.Status GetStatus() => status;

        public MainForm.Status OnStatus() => MainForm.Status.Running;

        public void ToShow() {
            status = OnStatus();
            this.Show();
        }
        #endregion

        private void QuestionBoard_Shown(object sender, EventArgs e) {
            Themes[0] = new Q1();
            ThemeControl[0] = Themes[0] as UserControl;
            ThemeControl[1] = Options[0];
            ThemeControl[2] = SubmitBtn;
            for (int i = 0; i < MaxIdx; ++i) {
                (Themes[i] as UserControl).Dock = DockStyle.Fill;
                Themes[i].SetFile($"questions/Q{i+1}desc.txt");
                Themes[i].TextLoad();
                Options[i] = new VariableRadioPanel {
                    FlowDirection = FlowDirection.LeftToRight,
                    Dock = DockStyle.Fill
                };
                Options[i].LoadContent($"questions/Q{i+1}.csv");
            }
            MoveToNext();
        }
        /// <summary>
        /// SubmitStatus
        /// it should be confirm if true
        /// and be next if false
        /// </summary>
        private bool SubmitStatus = false;
        private void SubmitBtn_Click(object sender, EventArgs e) {
            SubmitBtn.Text=SubmitStatus?"确定":"下一题";
            if (SubmitStatus) {
                MoveToNext();
                ++Index;
            }
            if (Index > MaxIdx) {
                status = MainForm.Status.Main;
                this.Hide();
            }
            if (Index == MaxIdx) {
                MoveToNext();
                SubmitBtn.Text = "返回主页";
                ++Index;
            }
            SubmitStatus = !SubmitStatus;
        }
        private void MoveToNext() {
            ThemeTable.SuspendLayout();

            ThemeTable.Controls.Clear();
            if (Index == MaxIdx) {
                ThemeControl[0] = EmptyTag as UserControl;
                ThemeControl[1] = EmptyTag as UserControl;
            } else {
                ThemeControl[0] = Themes[Index] as UserControl;
                ThemeControl[1] = Options[Index];
            }
            ThemeTable.Controls.AddRange(ThemeControl);

            ThemeTable.ResumeLayout(true);
        }
    }
}
