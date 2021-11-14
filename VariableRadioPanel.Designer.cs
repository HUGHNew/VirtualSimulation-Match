
namespace GUI {
    partial class VariableRadioPanel {
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
            this.SuspendLayout();
            // 
            // RadioFlow
            // 
            this.RadioFlow.BackColor = System.Drawing.Color.Transparent;
            this.RadioFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioFlow.Location = new System.Drawing.Point(0, 0);
            this.RadioFlow.Name = "RadioFlow";
            this.RadioFlow.Size = new System.Drawing.Size(150, 150);
            this.RadioFlow.TabIndex = 0;
            // 
            // VariableRadioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.RadioFlow);
            this.Name = "VariableRadioPanel";
            this.Load += new System.EventHandler(this.Test);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.RadioPanel_Layout);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RadioFlow;
    }
}
