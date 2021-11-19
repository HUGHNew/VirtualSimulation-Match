
namespace GUI {
    partial class QDesc {
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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.RichTextBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(544, 400);
            this.Panel.TabIndex = 0;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Location = new System.Drawing.Point(3, 150);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(538, 247);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            // 
            // QDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "QDesc";
            this.Size = new System.Drawing.Size(544, 400);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.IsometricLayout);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.RichTextBox RichTextBox;
    }
}
