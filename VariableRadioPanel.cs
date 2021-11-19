using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    [Obsolete]
    public partial class VariableRadioPanel : UserControl {
        public VariableRadioPanel() {
            InitializeComponent();
        }
        #region Browsable Properties
        [Browsable(true)]
        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the direction in which controls are laid out.")]
        public FlowDirection FlowDirection {
            get { return RadioFlow.FlowDirection; }
            set { RadioFlow.FlowDirection = value; }
        }
        [Browsable(true)]
        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the default single padding value.")]
        public int DefaultPaddingValue { get; set; } = 2;
        [Browsable(true)]
        [Category("Radio")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the CSV file for Radio Buttons.")]
        public string RadioCSVFile { get; set; } = "";
        [Browsable(true)]
        [Category("Radio")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the correct answer start with 1.")]
        public uint CorrectRadioItemIndex { get; set; } = 0;
        #endregion
        protected override Padding DefaultPadding {
            get {
                switch (FlowDirection) {
                    case FlowDirection.TopDown:
                        return new Padding(0, 0, 0, 2);
                    case FlowDirection.BottomUp:
                        return new Padding(0, 2, 0, 0);
                    case FlowDirection.LeftToRight:
                        return new Padding(0, 0, 2, 0);
                    case FlowDirection.RightToLeft:
                        return new Padding(0, 0, 2, 0);
                    default: return new Padding(0);
                }
            }
        }

        protected RadioButton[] Buttons;
        private void RadioPanel_Layout(object sender, LayoutEventArgs e) {
            int Xdelta = 0, Ydelta = 0, BWidth = 0, BHeight = 0;
            int Xpad = Padding.Left + Padding.Right, Ypad = Padding.Top + Padding.Bottom;
            void SetSize(bool vertical) {
                int Count = RadioFlow.Controls.Count + 1;
                if (vertical) {
                    BWidth = Width;
                    BHeight = (Height - Ypad * Count) / Count;
                    Ydelta = BHeight;
                } else {
                    BWidth = (Width - Xpad * Count) / Count;
                    BHeight = Height;
                    Xdelta = BWidth;
                }
            }
            int X = Location.X, Y = Location.Y;
            switch (FlowDirection) {
                case FlowDirection.TopDown: SetSize(true); break;
                case FlowDirection.BottomUp:
                    SetSize(true);
                    Y += Height - BHeight; Ydelta = -Ydelta;
                    break;
                case FlowDirection.LeftToRight: SetSize(false); break;
                case FlowDirection.RightToLeft:
                    SetSize(false);
                    X += Width - BWidth; Xdelta = -Xdelta;
                    break;
            }
            foreach (Control it in RadioFlow.Controls) {
                it.Location = new Point(X, Y);
                it.Size = new Size(BWidth, BHeight);
                X += Xdelta + Xpad; Y += Ydelta + Ypad;
            }
        }
        private void ButtonLoad(string path) {
            char[] sep = { ',' };
            string[] Texts = System.IO.File.ReadAllLines(path);
            uint CorrectAnswer = Convert.ToUInt32(Texts[0]);
            if (CorrectRadioItemIndex == 0) CorrectRadioItemIndex = CorrectAnswer;
            Buttons = new RadioButton[Texts.Length - 1];
            string CombineText(string[] text) {
                if (text == null || text.Length == 0)
                    throw new ArgumentException("empty string is not accepted!");
                else if (text.Length == 1) return text[0];
                else return text[0] + " : " + text[1];
            }
            for (int i = 0; i < Buttons.Length; ++i) {
                string[] item = Texts[i + 1].Split(sep, 2);
                Buttons[i] = new RadioButton {
                    Text = CombineText(item),
                    TabIndex = i,
                    TabStop = true,
                    UseVisualStyleBackColor = true
                };
            }
        }
        private void ButtonLoad() { ButtonLoad(RadioCSVFile); }
        public void LoadContent(string path) {
            this.SuspendLayout();
            RadioFlow.SuspendLayout();

            ButtonLoad(path);
            RadioFlow.Controls.Clear();
            RadioFlow.Controls.AddRange(Buttons);

            RadioFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            PerformLayout();
        }
        public void LoadContent() {
            RadioCSVFile =
                RadioCSVFile == ""
                ? DefaultRadioFile
                : RadioCSVFile;
            LoadContent(RadioCSVFile);
        }
        public const string demofile = "demo.csv";
        public static string DefaultRadioFile => System.IO.Path.Combine(Application.StartupPath, "questions", demofile);

        private void Test(object sender, EventArgs e) {

        }
    }
}
