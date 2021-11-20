using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public class Appraisal : Form, IVEInter {
        private FlowLayoutPanel MenuFlowLayoutPanel;
        private TextBox CText;
        private Button RetMenu;
        public Appraisal() {
            InitializeComponent();
            this.CText.Text = Properties.Resources.idop;
            status = MainForm.Status.Appraisal;
        }
        private void InitializeComponent() {
            this.MenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RetMenu = new System.Windows.Forms.Button();
            this.CText = new System.Windows.Forms.TextBox();
            this.MenuFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuFlowLayoutPanel.Controls.Add(this.RetMenu);
            this.MenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(122, 411);
            this.MenuFlowLayoutPanel.TabIndex = 2;
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
            // CText
            // 
            this.CText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CText.Dock = System.Windows.Forms.DockStyle.Top;
            this.CText.Location = new System.Drawing.Point(122, 0);
            this.CText.Multiline = true;
            this.CText.Name = "CText";
            this.CText.ReadOnly = true;
            this.CText.Size = new System.Drawing.Size(342, 100);
            this.CText.TabIndex = 3;
            // 
            // Appraisal
            // 
            this.BackgroundImage = global::GUI.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 411);
            this.Controls.Add(this.CText);
            this.Controls.Add(this.MenuFlowLayoutPanel);
            this.Name = "Appraisal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "鉴定意见";
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

        public MainForm.Status OnStatus() => MainForm.Status.Appraisal;

        public void ToShow(Point location) {
            status = OnStatus();
            Show();
            Location = location;
        }

        protected MainForm.Status status;
    }
}
