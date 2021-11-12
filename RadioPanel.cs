using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class RadioPanel : UserControl {
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
        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies descriptions for Radio Buttons.(4 lines is must)")]
        public string[] RadioData { get; set; } = new string[4];
        [Browsable(true)]
        [Category("Radio")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specifies the CSV file for Radio Buttons.")]
        public int CorrectRadioItemIndex { get; set; } = 0;
        #region Obsolete Properities
        //[Browsable(true)]
        //[Category("Layout")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[Description("Specifies the count of radio buttons.")]
        //public int MultipleRadioButtonCount { get; set; } = 4;
        #endregion
        protected override Padding DefaultPadding { 
            get {
                switch (FlowDirection) {
                    case FlowDirection.TopDown:
                        return new Padding(0,0,0,2);
                    case FlowDirection.BottomUp:
                        return new Padding(0, 2, 0, 0);
                    case FlowDirection.LeftToRight:
                        return new Padding(0, 0, 2, 0);
                    case FlowDirection.RightToLeft:
                        return new Padding(0, 0, 2, 0);
                    default:return new Padding(0);
                }
            }
        }
        public RadioPanel() {
            InitializeComponent();
        }
        private void RadioPanel_Layout(object sender, LayoutEventArgs e) {
            int Xdelta = 0, Ydelta = 0, BWidth = 0, BHeight = 0;
            int Xpad= Padding.Left + Padding.Right, Ypad= Padding.Top + Padding.Bottom;
            void SetSize(bool vertical) {
                int Count = RadioFlow.Controls.Count+1;
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
                    Y += Height-BHeight;Ydelta = -Ydelta;
                    break;
                case FlowDirection.LeftToRight: SetSize(false); break;
                case FlowDirection.RightToLeft:
                    SetSize(false);
                    X += Width-BWidth;Xdelta = -Xdelta;
                    break;
            }
            foreach(Control it in RadioFlow.Controls) {
                it.Location = new Point(X,Y);
                it.Size = new Size(BWidth,BHeight);
                X += Xdelta+Xpad;Y += Ydelta+Ypad;
            }
        }

        private void RadionContentLoad(object sender, EventArgs e) {
            if (RadioData == null || RadioData.Length != 4) {
                MessageBox.Show("DataItems don't match or are null");
                throw new Exception("DataItems don't match or are null");
            } else {
                A.Text = RadioData[0];
                B.Text = RadioData[1];
                C.Text = RadioData[2];
                D.Text = RadioData[3];
            }
        }
    }
}
