
namespace GUI {
    partial class Question {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.radioPanel1 = new GUI.RadioPanel();
            this.SuspendLayout();
            // 
            // radioPanel1
            // 
            this.radioPanel1.CorrectRadioItemIndex = 0;
            this.radioPanel1.DefaultPaddingValue = 2;
            this.radioPanel1.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.radioPanel1.Location = new System.Drawing.Point(122, 169);
            this.radioPanel1.Name = "radioPanel1";
            this.radioPanel1.RadioData = new string[] {
        "A",
        "B",
        "C",
        "D"};
            this.radioPanel1.Size = new System.Drawing.Size(418, 107);
            this.radioPanel1.TabIndex = 0;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioPanel1);
            this.Name = "Question";
            this.Text = "Question";
            this.ResumeLayout(false);

        }

        #endregion

        private RadioPanel radioPanel1;
    }
}