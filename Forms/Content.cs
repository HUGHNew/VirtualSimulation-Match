using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public class Content : Form, IVEInter {
        private Button RetMenu;
        private Button Anomaly;
        private TextBox CText;
        private FlowLayoutPanel MenuFlowLayoutPanel;
        public Content() {
            InitializeComponent();
            this.CText.Text = Properties.Resources.content;
            status = MainForm.Status.Issue;
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
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(122, 411);
            this.MenuFlowLayoutPanel.TabIndex = 1;
            // 
            // RetMenu
            // 
            this.RetMenu.Location = new System.Drawing.Point(3, 3);
            this.RetMenu.Name = "RetMenu";
            this.RetMenu.Size = new System.Drawing.Size(111, 40);
            this.RetMenu.TabIndex = 0;
            this.RetMenu.Text = "返回主页";
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
            this.Anomaly.Click += new System.EventHandler(this.JumpAnalyze);
            // 
            // CText
            // 
            this.CText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CText.Dock = System.Windows.Forms.DockStyle.Top;
            this.CText.Location = new System.Drawing.Point(122, 0);
            this.CText.Multiline = true;
            this.CText.Name = "CText";
            this.CText.ReadOnly = true;
            this.CText.Size = new System.Drawing.Size(342, 100);
            this.CText.TabIndex = 2;
            // 
            // Content
            // 
            this.BackgroundImage = global::GUI.Properties.Resources.Fight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 411);
            this.Controls.Add(this.CText);
            this.Controls.Add(this.MenuFlowLayoutPanel);
            this.Name = "Content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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

        public void ToShow() {
            status = OnStatus();
            this.Show();
        }
        public void ToShow(Point location) {
            status = OnStatus();
            Show();
            Location = location;
        }
        public MainForm.Status OnStatus() => MainForm.Status.Issue;
        protected MainForm.Status status;

        private void JumpAnalyze(object sender, EventArgs e) {
            ReturnProc(MainForm.Status.Crops);
        }
    }
}
