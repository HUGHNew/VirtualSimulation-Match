
namespace GUI {
    partial class Q1 {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.Title);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(593, 386);
            this.Panel.TabIndex = 0;
            this.Panel.Layout += new System.Windows.Forms.LayoutEventHandler(this.IsometricLayout);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Title.Location = new System.Drawing.Point(3, 331);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(587, 55);
            this.Title.TabIndex = 0;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "Q1";
            this.Size = new System.Drawing.Size(593, 386);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Label Title;
    }
}
