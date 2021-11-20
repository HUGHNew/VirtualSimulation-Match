using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI {
    public partial class QuestionBoard : Form, IVEInter {
        public QuestionBoard() {
            InitializeComponent();
            AShow = new TransparentLableForm();
        }
        private const uint MaxIdx = 5;
        private readonly VariableBasePanel[] Options = new VariableBasePanel[MaxIdx];
        private readonly QDesc[] Themes = new QDesc[MaxIdx];
        private readonly QDesc EmptyTag = new QDesc(Properties.Resources.finishExam);
        private readonly Control[] ThemeControl = new Control[3];
        private uint Index = 0;
        private MainForm.Status status;
        private readonly TransparentLableForm AShow;// show answer
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
        public void ToShow(Point location) {
            status = OnStatus();
            Show();
            Location = location;
        }
        #endregion
        private void ReturnMainPage() {
            AShow.Hide();
            ReturnPage(MainForm.Status.Main);
        }
        private void ReturnPage(MainForm.Status s) {
            status = s;
            this.Hide();
        }
        //private readonly Font dFont; // default font

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
        private Point ComputeFeedBackPosition(ref int width) {
            //Point pOrigin = ThemeTable.Controls[2].Location;
            int Y = Location.Y+Height-SubmitBtn.Size.Height;
            int X_offset = ThemeTable.Width - SubmitBtn.Width;
            width = (X_offset >> 1)+(X_offset>>2);
            X_offset = (ThemeTable.Width-width) >> 1;
            int X = Location.X+MenuFlow.Width+X_offset;
#if DEBUG
            Console.WriteLine($"ThemeTable.Width:{ThemeTable.Width}");
            Console.WriteLine($"{X},{Y} offset:{X_offset} width:{width}");
            Console.WriteLine($"Button:{SubmitBtn.Location}");
            //MessageBox.Show($"{pOrigin} {X},{Y}");
#endif
            return new Point(X, Y);
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
                AShow.Hide();
                MoveToNext();
            } else if (Index < MaxIdx) {
                int fd_width = 0;
                AShow.Location = ComputeFeedBackPosition(ref fd_width);
                AShow.ReSize(new Size(fd_width, ThemeTable.Controls[2].Height >> 1));
                if (Options[Index].IsCorrect()) {
                    //MessageBox.Show("答案正确");
                    AShow.ContentLoad();
                } else {
                    string result = "正确答案为：" + 
                        Options[Index].GetAnswers().
                        Select(it => (char)(it - 1 + 'A')).ToArrayString();
                    //MessageBox.Show("正确答案为：" + Options[Index].GetAnswers().Select(it => (char)(it - 1 + 'A')).ToArrayString());
                    AShow.ContentLoad(result,Color.Red);
                }
                AShow.ResizeLabel();
                AShow.Show();
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
        #region Page Jump
        private void JumpContent(object sender, EventArgs e) {
            ReturnPage(MainForm.Status.Appraisal);
        }

        private void JumpCrops(object sender, EventArgs e) {
            ReturnPage(MainForm.Status.Crops);
        }
        private void CloseAction(object sender, FormClosingEventArgs e) {
            ReturnMainPage();
        }
        #endregion
    }
}
