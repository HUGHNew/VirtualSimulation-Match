using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class QDesc : UserControl {
        public QDesc() {
            InitializeComponent();
            RichTextBox.BackColor = Color.FromArgb(186, 228, 226);
            RichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
        public static string NewLine(int count) {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(count);
            for(int i=0;i<count;++i)
                sb.Append('\n');
            return sb.ToString();
        }
        public void TryLoadRtf(string path) {
            if (File.Exists(path)) {
                LoadFile(path);
            } else {
                char[] sep = { '.' };
                RichTextBox.Text = NewLine(5)+File.ReadAllText(path.Split(sep)[0] + ".txt");
                //LoadU8Plain(path.Split(sep)[0]+".txt");
                //RichTextBox.LoadFile(path.Split(sep)[0] + ".txt");
            }
        }
        public void LoadFile(string path, RichTextBoxStreamType Type= RichTextBoxStreamType.RichText) {
            RichTextBox.LoadFile(path, Type);
        }
        public void LoadU8Plain(string path) {
            RichTextBox.LoadFile(path, RichTextBoxStreamType.UnicodePlainText);
        }
        protected override CreateParams CreateParams {
            get {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }
        private void IsometricLayout(object sender, LayoutEventArgs e) {
            int RichBoxHeight = (int)(Height * 0.8);
            RichTextBox.Size = new Size(Width, RichBoxHeight);
            RichTextBox.Location = 
                new Point(Location.X,Location.Y+Height-RichBoxHeight);
            //int LHeight = Height / Controls.Count;
            //int Y = Location.Y;
            //foreach (Control it in Controls) {
            //    it.Size = new Size(Width, LHeight);
            //    it.Location = new Point(it.Location.X, Y);
            //    Y += LHeight;
            //}
        }
    }
}
