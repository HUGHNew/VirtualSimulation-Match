using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public class VariableCheckPanel : VariableBasePanel {
        [Browsable(true)]
        [Category("Buttons")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the correct answer start with 1.")]
        public uint[] CorrectButtonItemIndex { get; set; }
        protected override void ButtonLoad(string path) {
            char[] sep = { ',' };
            string[] Texts = System.IO.File.ReadAllLines(path);
            uint[] CorrectAnswers = Texts[0].Split(sep).Select(it=> Convert.ToUInt32(it)).ToArray();
            if (CorrectButtonItemIndex == null) CorrectButtonItemIndex = CorrectAnswers;
            Buttons = new CheckBox[Texts.Length - 1];
            string CombineText(string[] text) {
                if (text == null || text.Length == 0)
                    throw new ArgumentException("empty string is not accepted!");
                else if (text.Length == 1) return text[0];
                else return text[0] + " : " + text[1];
            }
            for (int i = 0; i < Buttons.Length; ++i) {
                string[] item = Texts[i + 1].Split(sep, 2);
                Buttons[i] = new CheckBox {
                    Text = CombineText(item),
                    TabIndex = i,
                    TabStop = true,
                    UseVisualStyleBackColor = true
                };
            }
        }
        public override void LoadContent(string path) {
            SuspendLayout();
            ButtonLoad(path);
            Controls.Clear();
            Controls.AddRange(Buttons);
            ResumeLayout(true);
        }

        protected CheckBox[] Buttons;
    }
}
