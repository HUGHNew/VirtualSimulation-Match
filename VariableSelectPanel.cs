﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GUI {
    public class VariableSelectPanel : VariableBasePanel {
        [Browsable(true)]
        [Category("Buttons")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the correct answer start with 1.")]
        public uint CorrectButtonItemIndex { get; set; } = 0;
        protected override void ButtonLoad(string path) {
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

        protected RadioButton[] Buttons;
    }
}
