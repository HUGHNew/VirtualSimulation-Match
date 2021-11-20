using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class TransparentLableForm : Form {
        protected readonly FontFamily family = new FontFamily(Label.DefaultFont.Name);
        private readonly Color color;
        public readonly Color NormalColor = Color.Blue;
        public const string normal = "回答正确";
        const float alpha = 1.7f;
        public TransparentLableForm() {
            Initialization();
        }
        public TransparentLableForm(String content, Color color) {
            Initialization();
            this.color = color;
            ContentLoad(content);
            Size = new Size(Width, (int)label.Font.Size + 50);
        }
        private void Initialization() {
            InitializeComponent();
            ClickToClose();
        }
        private void ClickToClose() {
#if DEBUG
            void LEvent(object sender, System.EventArgs e) { Close(); }
            label.Click += LEvent;
#endif
        }
        public void ContentLoad() {
            ContentLoad(normal, NormalColor);
        }
        public void ContentLoad(string content) {
            ContentLoad(content, color);
        }
        public void ContentLoad(string content, Color contentColor) {
            label.Text = content;
            label.ForeColor = contentColor;
            LabelLoad(ComputeContentFontSize(content.Length));
        }
        private float ComputeContentFontSize(int length) {
            float expectedSize = label.Width / (length * alpha);
            return expectedSize < label.Height
                ? expectedSize : label.Height;
        }
        private void LabelLoad(float fontSize) {
            label.Font = new Font(family, fontSize, FontStyle.Regular);
            label.ForeColor = color;
        }
        public String Content { get { return label.Text; } set { ContentLoad(value); } }
        public TransparentLableForm ReSize(Size size,bool load=false) {
            Size = size;
            label.Size = size;
            if (load) { Content=Content; }
            return this;
        }
        public void ResizeLabel() {
            LabelLoad(ComputeContentFontSize(Content.Length));
        }
    }
}
