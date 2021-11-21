
namespace GUI {
    partial class Crops {
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
            this.MenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.BodyCheck_Btn = new System.Windows.Forms.Button();
            this.OrganCheck_Btn = new System.Windows.Forms.Button();
            this.TissueCheck_Btn = new System.Windows.Forms.Button();
            this.DrugCheck_Btn = new System.Windows.Forms.Button();
            this.Pathological_Btn = new System.Windows.Forms.Button();
            this.AnalyDesc_Btn = new System.Windows.Forms.Button();
            this.MenuFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ToExp_Btn = new System.Windows.Forms.Button();
            this.AppOption_Btn = new System.Windows.Forms.Button();
            this.RetMain_Btn = new System.Windows.Forms.Button();
            this.CropPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.ItemFlow.SuspendLayout();
            this.MenuFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.ColumnCount = 1;
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuPanel.Controls.Add(this.ItemFlow, 0, 0);
            this.MenuPanel.Controls.Add(this.MenuFlow, 0, 2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.RowCount = 3;
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPanel.Size = new System.Drawing.Size(151, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // ItemFlow
            // 
            this.ItemFlow.Controls.Add(this.BodyCheck_Btn);
            this.ItemFlow.Controls.Add(this.OrganCheck_Btn);
            this.ItemFlow.Controls.Add(this.TissueCheck_Btn);
            this.ItemFlow.Controls.Add(this.DrugCheck_Btn);
            this.ItemFlow.Controls.Add(this.Pathological_Btn);
            this.ItemFlow.Controls.Add(this.AnalyDesc_Btn);
            this.ItemFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemFlow.Location = new System.Drawing.Point(3, 3);
            this.ItemFlow.Name = "ItemFlow";
            this.ItemFlow.Size = new System.Drawing.Size(145, 264);
            this.ItemFlow.TabIndex = 0;
            this.ItemFlow.Layout += new System.Windows.Forms.LayoutEventHandler(this.ItemLayout);
            this.ItemFlow.Resize += new System.EventHandler(this.ItemResize);
            // 
            // BodyCheck_Btn
            // 
            this.BodyCheck_Btn.FlatAppearance.BorderSize = 0;
            this.BodyCheck_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.BodyCheck_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BodyCheck_Btn.Location = new System.Drawing.Point(3, 3);
            this.BodyCheck_Btn.Name = "BodyCheck_Btn";
            this.BodyCheck_Btn.Size = new System.Drawing.Size(138, 26);
            this.BodyCheck_Btn.TabIndex = 0;
            this.BodyCheck_Btn.Text = "尸体检验";
            this.BodyCheck_Btn.UseVisualStyleBackColor = true;
            this.BodyCheck_Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // OrganCheck_Btn
            // 
            this.OrganCheck_Btn.FlatAppearance.BorderSize = 0;
            this.OrganCheck_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.OrganCheck_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrganCheck_Btn.Location = new System.Drawing.Point(3, 35);
            this.OrganCheck_Btn.Name = "OrganCheck_Btn";
            this.OrganCheck_Btn.Size = new System.Drawing.Size(138, 26);
            this.OrganCheck_Btn.TabIndex = 1;
            this.OrganCheck_Btn.Text = "器官检验";
            this.OrganCheck_Btn.UseVisualStyleBackColor = true;
            this.OrganCheck_Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // TissueCheck_Btn
            // 
            this.TissueCheck_Btn.FlatAppearance.BorderSize = 0;
            this.TissueCheck_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.TissueCheck_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TissueCheck_Btn.Location = new System.Drawing.Point(3, 67);
            this.TissueCheck_Btn.Name = "TissueCheck_Btn";
            this.TissueCheck_Btn.Size = new System.Drawing.Size(138, 26);
            this.TissueCheck_Btn.TabIndex = 2;
            this.TissueCheck_Btn.Text = "组织检查";
            this.TissueCheck_Btn.UseVisualStyleBackColor = true;
            this.TissueCheck_Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // DrugCheck_Btn
            // 
            this.DrugCheck_Btn.FlatAppearance.BorderSize = 0;
            this.DrugCheck_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.DrugCheck_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrugCheck_Btn.Location = new System.Drawing.Point(3, 99);
            this.DrugCheck_Btn.Name = "DrugCheck_Btn";
            this.DrugCheck_Btn.Size = new System.Drawing.Size(138, 26);
            this.DrugCheck_Btn.TabIndex = 3;
            this.DrugCheck_Btn.Text = "毒物分析";
            this.DrugCheck_Btn.UseVisualStyleBackColor = true;
            this.DrugCheck_Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Pathological_Btn
            // 
            this.Pathological_Btn.FlatAppearance.BorderSize = 0;
            this.Pathological_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Pathological_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pathological_Btn.Location = new System.Drawing.Point(3, 131);
            this.Pathological_Btn.Name = "Pathological_Btn";
            this.Pathological_Btn.Size = new System.Drawing.Size(138, 26);
            this.Pathological_Btn.TabIndex = 4;
            this.Pathological_Btn.Text = "病理诊断";
            this.Pathological_Btn.UseVisualStyleBackColor = true;
            this.Pathological_Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // AnalyDesc_Btn
            // 
            this.AnalyDesc_Btn.FlatAppearance.BorderSize = 0;
            this.AnalyDesc_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AnalyDesc_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyDesc_Btn.Location = new System.Drawing.Point(3, 163);
            this.AnalyDesc_Btn.Name = "AnalyDesc_Btn";
            this.AnalyDesc_Btn.Size = new System.Drawing.Size(138, 26);
            this.AnalyDesc_Btn.TabIndex = 5;
            this.AnalyDesc_Btn.Text = "分析说明";
            this.AnalyDesc_Btn.UseVisualStyleBackColor = true;
            this.AnalyDesc_Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // MenuFlow
            // 
            this.MenuFlow.Controls.Add(this.ToExp_Btn);
            this.MenuFlow.Controls.Add(this.AppOption_Btn);
            this.MenuFlow.Controls.Add(this.RetMain_Btn);
            this.MenuFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuFlow.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.MenuFlow.Location = new System.Drawing.Point(3, 318);
            this.MenuFlow.Name = "MenuFlow";
            this.MenuFlow.Size = new System.Drawing.Size(145, 129);
            this.MenuFlow.TabIndex = 1;
            this.MenuFlow.Layout += new System.Windows.Forms.LayoutEventHandler(this.MenuLayout);
            this.MenuFlow.Resize += new System.EventHandler(this.MenuResize);
            // 
            // ToExp_Btn
            // 
            this.ToExp_Btn.Location = new System.Drawing.Point(3, 100);
            this.ToExp_Btn.Name = "ToExp_Btn";
            this.ToExp_Btn.Size = new System.Drawing.Size(138, 26);
            this.ToExp_Btn.TabIndex = 6;
            this.ToExp_Btn.Text = "开始实验";
            this.ToExp_Btn.UseVisualStyleBackColor = true;
            this.ToExp_Btn.Click += new System.EventHandler(this.JumpExperiment);
            // 
            // AppOption_Btn
            // 
            this.AppOption_Btn.Location = new System.Drawing.Point(3, 68);
            this.AppOption_Btn.Name = "AppOption_Btn";
            this.AppOption_Btn.Size = new System.Drawing.Size(138, 26);
            this.AppOption_Btn.TabIndex = 7;
            this.AppOption_Btn.Text = "鉴定意见";
            this.AppOption_Btn.UseVisualStyleBackColor = true;
            this.AppOption_Btn.Click += new System.EventHandler(this.JumpAppraisal);
            // 
            // RetMain_Btn
            // 
            this.RetMain_Btn.Location = new System.Drawing.Point(3, 36);
            this.RetMain_Btn.Name = "RetMain_Btn";
            this.RetMain_Btn.Size = new System.Drawing.Size(138, 26);
            this.RetMain_Btn.TabIndex = 8;
            this.RetMain_Btn.Text = "返回主页";
            this.RetMain_Btn.UseVisualStyleBackColor = true;
            this.RetMain_Btn.Click += new System.EventHandler(this.Return);
            // 
            // CropPanel
            // 
            this.CropPanel.BackColor = System.Drawing.Color.Transparent;
            this.CropPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CropPanel.Location = new System.Drawing.Point(154, 0);
            this.CropPanel.Name = "CropPanel";
            this.CropPanel.Size = new System.Drawing.Size(646, 450);
            this.CropPanel.TabIndex = 2;
            // 
            // Crops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.CropPanel);
            this.Name = "Crops";
            this.Text = "尸体解剖";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseAction);
            this.Load += new System.EventHandler(this.TextLoad);
            this.MenuPanel.ResumeLayout(false);
            this.ItemFlow.ResumeLayout(false);
            this.MenuFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MenuPanel;
        private System.Windows.Forms.FlowLayoutPanel ItemFlow;
        private System.Windows.Forms.FlowLayoutPanel MenuFlow;
        private System.Windows.Forms.Button BodyCheck_Btn;
        private System.Windows.Forms.Button OrganCheck_Btn;
        private System.Windows.Forms.Button TissueCheck_Btn;
        private System.Windows.Forms.Button DrugCheck_Btn;
        private System.Windows.Forms.Button Pathological_Btn;
        private System.Windows.Forms.Button AnalyDesc_Btn;
        private System.Windows.Forms.Button ToExp_Btn;
        private System.Windows.Forms.Button AppOption_Btn;
        private System.Windows.Forms.Button RetMain_Btn;
        private System.Windows.Forms.Panel CropPanel;
    }
}