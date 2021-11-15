using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUI {
    public partial class Q1 : UserControl,IQTag {
        public Q1() {
            InitializeComponent();
        }
        protected override CreateParams CreateParams {
            get {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }
        private void IsometricLayout(object sender, LayoutEventArgs e) {
            int LHeight = Height / Controls.Count;
            int Y = Location.Y;
            foreach(Control it in Controls) {
                it.Size = new Size(Width, LHeight);
                it.Location = new Point(it.Location.X, Y);
                Y += LHeight;
            }
        }
        #region Seems Useless?
        [Browsable(true)]
        [Category("Radio")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the text file for Label.")]
        public string TextFile { get; set; } = "questions/Q1desc.txt";
        public void TextLoad() {
            Title.Text = System.IO.File.ReadAllText(TextFile);
        }

        public void SetFile(string file) {
            TextFile = file;
        }
        #endregion
    }
}
