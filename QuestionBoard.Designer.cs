
namespace GUI {
    partial class QuestionBoard {
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.ThemeTable = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.MenuFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentBtn = new System.Windows.Forms.Button();
            this.CropCheckBtn = new System.Windows.Forms.Button();
            this.QuestionBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.ThemeTable.SuspendLayout();
            this.MenuFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.BackgroundImage = global::GUI.Properties.Resources.Bg;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainTable.Controls.Add(this.ThemeTable, 1, 0);
            this.MainTable.Controls.Add(this.MenuFlow, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // ThemeTable
            // 
            this.ThemeTable.ColumnCount = 1;
            this.ThemeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ThemeTable.Controls.Add(this.SubmitBtn, 0, 2);
            this.ThemeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThemeTable.Location = new System.Drawing.Point(123, 3);
            this.ThemeTable.Name = "ThemeTable";
            this.ThemeTable.RowCount = 3;
            this.ThemeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ThemeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ThemeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ThemeTable.Size = new System.Drawing.Size(674, 444);
            this.ThemeTable.TabIndex = 0;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.Location = new System.Drawing.Point(596, 358);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 83);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "确定";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // MenuFlow
            // 
            this.MenuFlow.Controls.Add(this.ContentBtn);
            this.MenuFlow.Controls.Add(this.CropCheckBtn);
            this.MenuFlow.Controls.Add(this.QuestionBtn);
            this.MenuFlow.Controls.Add(this.ReturnBtn);
            this.MenuFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuFlow.Location = new System.Drawing.Point(3, 3);
            this.MenuFlow.Name = "MenuFlow";
            this.MenuFlow.Size = new System.Drawing.Size(114, 444);
            this.MenuFlow.TabIndex = 1;
            // 
            // ContentBtn
            // 
            this.ContentBtn.Location = new System.Drawing.Point(3, 3);
            this.ContentBtn.Name = "ContentBtn";
            this.ContentBtn.Size = new System.Drawing.Size(75, 23);
            this.ContentBtn.TabIndex = 0;
            this.ContentBtn.Text = "案情资料";
            this.ContentBtn.UseVisualStyleBackColor = true;
            // 
            // CropCheckBtn
            // 
            this.CropCheckBtn.Location = new System.Drawing.Point(3, 32);
            this.CropCheckBtn.Name = "CropCheckBtn";
            this.CropCheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CropCheckBtn.TabIndex = 1;
            this.CropCheckBtn.Text = "尸体检查";
            this.CropCheckBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionBtn
            // 
            this.QuestionBtn.Location = new System.Drawing.Point(3, 61);
            this.QuestionBtn.Name = "QuestionBtn";
            this.QuestionBtn.Size = new System.Drawing.Size(75, 23);
            this.QuestionBtn.TabIndex = 2;
            this.QuestionBtn.Text = "问题";
            this.QuestionBtn.UseVisualStyleBackColor = true;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(3, 90);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 3;
            this.ReturnBtn.Text = "返回主页";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTable);
            this.Name = "QuestionBoard";
            this.Text = "体位性窒息法医学鉴定虚拟仿真实验";
            this.Shown += new System.EventHandler(this.QuestionBoard_Shown);
            this.MainTable.ResumeLayout(false);
            this.ThemeTable.ResumeLayout(false);
            this.MenuFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TableLayoutPanel ThemeTable;
        private System.Windows.Forms.FlowLayoutPanel MenuFlow;
        private System.Windows.Forms.Button ContentBtn;
        private System.Windows.Forms.Button CropCheckBtn;
        private System.Windows.Forms.Button QuestionBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}