using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GUI {
    public class VariableSelectPanel : VariableBasePanel, IVariableOptionPanel {
        [Browsable(true)]
        [Category("Buttons")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the correct answer start with 1.")]
        public uint CorrectButtonItemIndex { get; set; } = 0;
        public void ButtonLoad(string path) {
            char[] sep = { ',' };
            string[] Texts = System.IO.File.ReadAllLines(path);
            uint CorrectAnswer = Convert.ToUInt32(Texts[0]);
            if (CorrectButtonItemIndex == 0) CorrectButtonItemIndex = CorrectAnswer;
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
        public override void LoadContent(string path) {
            this.SuspendLayout();

            ButtonLoad(path);
            Controls.Clear();
            Controls.AddRange(Buttons);

            this.ResumeLayout(true);
        }

        public override bool IsCorrect() {
            for (int i = 0; i < Buttons.Length; ++i) {
                if (Buttons[i].Checked)
                    return i + 1 == CorrectButtonItemIndex;
            }
            return false;
        }
        public override uint[] GetAnswers() => new uint[1] { CorrectButtonItemIndex };
        protected RadioButton[] Buttons;
    }
}
