
namespace GUI {
    partial class MainForm {
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
            this.IssueContent = new System.Windows.Forms.Button();
            this.MainButtonFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Anatomy = new System.Windows.Forms.Button();
            this.Appraisal = new System.Windows.Forms.Button();
            this.QA = new System.Windows.Forms.Button();
            this.MainButtonFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IssueContent
            // 
            this.IssueContent.Location = new System.Drawing.Point(3, 3);
            this.IssueContent.Name = "IssueContent";
            this.IssueContent.Size = new System.Drawing.Size(195, 50);
            this.IssueContent.TabIndex = 0;
            this.IssueContent.Text = "案情资料";
            this.IssueContent.UseVisualStyleBackColor = true;
            this.IssueContent.Click += new System.EventHandler(this.Content);
            // 
            // MainButtonFlowPanel
            // 
            this.MainButtonFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainButtonFlowPanel.Controls.Add(this.IssueContent);
            this.MainButtonFlowPanel.Controls.Add(this.Anatomy);
            this.MainButtonFlowPanel.Controls.Add(this.Appraisal);
            this.MainButtonFlowPanel.Location = new System.Drawing.Point(12, 336);
            this.MainButtonFlowPanel.Name = "MainButtonFlowPanel";
            this.MainButtonFlowPanel.Size = new System.Drawing.Size(776, 62);
            this.MainButtonFlowPanel.TabIndex = 0;
            this.MainButtonFlowPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.LineAverageLay);
            this.MainButtonFlowPanel.Resize += new System.EventHandler(this.ResizePanel);
            // 
            // Anatomy
            // 
            this.Anatomy.Location = new System.Drawing.Point(204, 3);
            this.Anatomy.Name = "Anatomy";
            this.Anatomy.Size = new System.Drawing.Size(195, 50);
            this.Anatomy.TabIndex = 1;
            this.Anatomy.Text = "尸体解剖";
            this.Anatomy.UseVisualStyleBackColor = true;
            this.Anatomy.Click += new System.EventHandler(this.CropsJump);
            // 
            // Appraisal
            // 
            this.Appraisal.Location = new System.Drawing.Point(405, 3);
            this.Appraisal.Name = "Appraisal";
            this.Appraisal.Size = new System.Drawing.Size(195, 50);
            this.Appraisal.TabIndex = 2;
            this.Appraisal.Text = "鉴定意见";
            this.Appraisal.UseVisualStyleBackColor = true;
            this.Appraisal.Click += new System.EventHandler(this.AppStart);
            // 
            // QA
            // 
            this.QA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QA.Location = new System.Drawing.Point(263, 189);
            this.QA.Name = "QA";
            this.QA.Size = new System.Drawing.Size(230, 69);
            this.QA.TabIndex = 1;
            this.QA.Text = "开始实验";
            this.QA.UseVisualStyleBackColor = true;
            this.QA.Click += new System.EventHandler(this.QAEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QA);
            this.Controls.Add(this.MainButtonFlowPanel);
            this.Name = "MainForm";
            this.Text = "体位性窒息法医学鉴定虚拟仿真实验";
            this.Load += new System.EventHandler(this.MainLoad);
            this.Resize += new System.EventHandler(this.MainResize);
            this.MainButtonFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button IssueContent;
        private System.Windows.Forms.FlowLayoutPanel MainButtonFlowPanel;
        private System.Windows.Forms.Button Anatomy;
        private System.Windows.Forms.Button Appraisal;
        private System.Windows.Forms.Button QA;
    }
}

