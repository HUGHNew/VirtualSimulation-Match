using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public class Content : Form,Status {
        private Button RetMenu;
        private Button Anomaly;
        private TextBox CText;
        private FlowLayoutPanel MenuFlowLayoutPanel;
        public Content(Size size,Point start) {
            InitializeComponent();
            this.Size = size;
            this.Location = start;
            this.CText.Text = "某年5月13日下午，李某（男，26岁）因不小心碰倒路边商贩张某贩卖的水果，" +
                "而张某因赚钱无路，愤恨于心，借李某撒气，遂两人殴打起来，没几个回合李某便倒地不醒，救护车到时已停止呼吸。" +
                "因张某否认罪行，其家属遂报警并要求尸体解剖查明死因。于李某死后2日进行尸体解剖。";
            status = MainForm.Status.Running;
        }

        private void InitializeComponent() {
            this.MenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RetMenu = new System.Windows.Forms.Button();
            this.Anomaly = new System.Windows.Forms.Button();
            this.CText = new System.Windows.Forms.TextBox();
            this.MenuFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuFlowLayoutPanel.Controls.Add(this.RetMenu);
            this.MenuFlowLayoutPanel.Controls.Add(this.Anomaly);
            this.MenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(122, 320);
            this.MenuFlowLayoutPanel.TabIndex = 1;
            // 
            // RetMenu
            // 
            this.RetMenu.Location = new System.Drawing.Point(3, 3);
            this.RetMenu.Name = "RetMenu";
            this.RetMenu.Size = new System.Drawing.Size(111, 40);
            this.RetMenu.TabIndex = 0;
            this.RetMenu.Text = "返回上级";
            this.RetMenu.UseVisualStyleBackColor = true;
            this.RetMenu.Click += new System.EventHandler(this.Return);
            // 
            // Anomaly
            // 
            this.Anomaly.Location = new System.Drawing.Point(3, 49);
            this.Anomaly.Name = "Anomaly";
            this.Anomaly.Size = new System.Drawing.Size(111, 38);
            this.Anomaly.TabIndex = 1;
            this.Anomaly.Text = "尸体解剖";
            this.Anomaly.UseVisualStyleBackColor = true;
            // 
            // CText
            // 
            this.CText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CText.Dock = System.Windows.Forms.DockStyle.Top;
            this.CText.Location = new System.Drawing.Point(122, 0);
            this.CText.Multiline = true;
            this.CText.Name = "CText";
            this.CText.ReadOnly = true;
            this.CText.Size = new System.Drawing.Size(235, 103);
            this.CText.TabIndex = 2;
            // 
            // Content
            // 
            this.BackgroundImage = global::GUI.Properties.Resources.Fight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 320);
            this.Controls.Add(this.CText);
            this.Controls.Add(this.MenuFlowLayoutPanel);
            this.Name = "Content";
            this.Text = "案情资料";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseAction);
            this.MenuFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Return(object sender, EventArgs e) {
            ReturnProc(MainForm.Status.Main);
        }

        protected void CloseAction(object sender, FormClosedEventArgs e) {
            ReturnProc(MainForm.Status.Main);
        }
        protected void ReturnProc(MainForm.Status s) {
            this.Hide();
            status = s;
        }

        public MainForm.Status GetStatus() {
            return status;
        }

        public void ToShow(MainForm.Status st) {
            status = st;
            this.Show();
        }

        protected MainForm.Status status;
    }
}
