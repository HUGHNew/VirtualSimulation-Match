using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI {
    public partial class QuestionBoard : Form, IVEInter {
        public QuestionBoard() {
            InitializeComponent();
        }
        private const uint MaxIdx = 5;
        private readonly VariableBasePanel[] Options = new VariableBasePanel[MaxIdx];
        private readonly QDesc[] Themes = new QDesc[MaxIdx];
        private readonly QDesc EmptyTag = new QDesc(Properties.Resources.finishExam);
        private readonly Control[] ThemeControl = new Control[3];
        private uint Index = 0;
        private MainForm.Status status;
        // copy with the flash problem
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
        private void ReturnMainPage() {
            ReturnPage(MainForm.Status.Main);
        }
        private void ReturnPage(MainForm.Status s) {
            status = s;
            this.Hide();
        }
        private readonly Font dFont; // default font
        private Label NFLabelGen(string text) {
            return new Label {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                //Font=dFont,
            };
        }

        private void QuestionBoard_Shown(object sender, EventArgs e) {
            for (int i = 0; i < MaxIdx; ++i) {
                Themes[i] = new QDesc { Dock = DockStyle.Fill };
                Themes[i].TryLoadRtf($"questions/Q{i + 1}desc.rtf");

                string csv = $"questions/Q{i + 1}.csv";
                Options[i] = VariablePanelFactory.Create(csv);
                Options[i].FlowDirection = FlowDirection.LeftToRight;
                Options[i].LoadContent(csv);
            }
            ThemeControl[2] = SubmitBtn;
            MoveToNext();
        }
        /// <summary>
        /// SubmitStatus
        /// it should be confirm if true
        /// and be next if false
        /// </summary>
        private bool SubmitStatus = false;
        private void SubmitBtn_Click(object sender, EventArgs e) {
            SubmitBtn.Text = SubmitStatus ? "确定" : "下一题";
            if (SubmitStatus) {
                ++Index;
                MoveToNext();
            } else if (Index < MaxIdx) {
                if (Options[Index].IsCorrect()) {
                    MessageBox.Show("答案正确");
                } else {
                    MessageBox.Show("正确答案为：" + Options[Index].GetAnswers().Select(it => (char)(it - 1 + 'A')).ToArrayString());
                }
            }
            if (Index > MaxIdx) {
                ReturnMainPage();
            }
            if (Index == MaxIdx) {
                ++Index;
                MoveToNext();
                SubmitBtn.Text = "返回主页";
            }
            SubmitStatus = !SubmitStatus;
        }
        private void MoveToNext() {
            ThemeTable.SuspendLayout();

            ThemeTable.Controls.Clear();
            if (Index >= MaxIdx) {
                ThemeControl[0] = EmptyTag;
                ThemeControl[1] = null;
            } else {
                ThemeControl[0] = Themes[Index];
                ThemeControl[1] = Options[Index];
            }
            ThemeTable.Controls.AddRange(ThemeControl);

            ThemeTable.ResumeLayout(true);
        }

        private void BtnReturnMain(object sender, EventArgs e) {
            ReturnMainPage();
        }

        private void Menu_Layout(object sender, LayoutEventArgs e) {
            int BlkHeight = (MenuFlow.Height >> 1) / MenuFlow.Controls.Count;
            Size BlkSize = new Size(MenuFlow.Width, BlkHeight);
            foreach (Control it in MenuFlow.Controls) {
                it.Size = BlkSize;
            }
        }

        private void JumpContent(object sender, EventArgs e) {
            ReturnPage(MainForm.Status.Appraisal);
        }

        private void JumpCrops(object sender, EventArgs e) {
            ReturnPage(MainForm.Status.Crops);
        }
        private void CloseAction(object sender, FormClosedEventArgs e) {
            ReturnMainPage();
        }
    }
}
