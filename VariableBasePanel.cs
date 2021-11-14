using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public abstract class VariableBasePanel:FlowLayoutPanel,IVariableOptionPanel {
        #region Browsable Properties
        [Browsable(true)]
        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the default single padding value.")]
        public int DefaultPaddingValue { get; set; } = 2;
        [Browsable(true)]
        [Category("Buttons")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the CSV file for Buttons.")]
        public string ButtonCSVFile { get; set; } = "";
        #endregion
        protected override Padding DefaultPadding {
            get {
                switch (FlowDirection) {
                    case FlowDirection.TopDown:
                        return new Padding(0, 0, 0, DefaultPaddingValue);
                    case FlowDirection.BottomUp:
                        return new Padding(0, DefaultPaddingValue, 0, 0);
                    case FlowDirection.LeftToRight:
                        return new Padding(0, 0, DefaultPaddingValue, 0);
                    case FlowDirection.RightToLeft:
                        return new Padding(0, 0, DefaultPaddingValue, 0);
                    default: return new Padding(0);
                }
            }
        }
        
        protected void ButtonsPanel_Layout(object sender, LayoutEventArgs e) {
            int Xdelta = 0, Ydelta = 0, BWidth = 0, BHeight = 0;
            int Xpad = Padding.Left + Padding.Right, Ypad = Padding.Top + Padding.Bottom;
            void SetSize(bool vertical) {
                int Count = Controls.Count + 1;
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
            foreach (Control it in Controls) {
                it.Location = new Point(X, Y);
                it.Size = new Size(BWidth, BHeight);
                X += Xdelta + Xpad; Y += Ydelta + Ypad;
            }
        }
        protected void ButtonLoad() { ButtonLoad(ButtonCSVFile); }
        protected void Initialization() {
            SuspendLayout();

            BackColor = Color.Transparent;
            Dock = DockStyle.Fill;

            Layout += new LayoutEventHandler(this.ButtonsPanel_Layout);

            ResumeLayout(false);
        }
        public VariableBasePanel() {
            Initialization();
        }
        protected UInt64 Answer=0;
        abstract public bool IsCorrect();
        abstract protected void ButtonLoad(string path);
        abstract public void LoadContent(string path);
    }
}
