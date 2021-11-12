
namespace GUI {
    partial class RadioPanel {
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
            this.RadioFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.RadioFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioFlow
            // 
            this.RadioFlow.BackColor = System.Drawing.Color.Transparent;
            this.RadioFlow.Controls.Add(this.A);
            this.RadioFlow.Controls.Add(this.B);
            this.RadioFlow.Controls.Add(this.C);
            this.RadioFlow.Controls.Add(this.D);
            this.RadioFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioFlow.Location = new System.Drawing.Point(0, 0);
            this.RadioFlow.Name = "RadioFlow";
            this.RadioFlow.Size = new System.Drawing.Size(150, 150);
            this.RadioFlow.TabIndex = 0;
            this.RadioFlow.Layout += new System.Windows.Forms.LayoutEventHandler(this.RadioPanel_Layout);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(3, 3);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(71, 16);
            this.A.TabIndex = 0;
            this.A.TabStop = true;
            this.A.Text = "Item : A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(3, 25);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(71, 16);
            this.B.TabIndex = 1;
            this.B.TabStop = true;
            this.B.Text = "Item : B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(3, 47);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(71, 16);
            this.C.TabIndex = 2;
            this.C.TabStop = true;
            this.C.Text = "Item : C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(3, 69);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(71, 16);
            this.D.TabIndex = 3;
            this.D.TabStop = true;
            this.D.Text = "Item : D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // RadioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadioFlow);
            this.Name = "RadioPanel";
            this.Load += new System.EventHandler(this.RadionContentLoad);
            this.RadioFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RadioFlow;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton D;
    }
}
