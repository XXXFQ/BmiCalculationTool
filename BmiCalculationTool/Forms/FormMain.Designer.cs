
namespace BmiCalculationTool.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBmiCalculate = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCentimeter = new System.Windows.Forms.Label();
            this.lblKilogram = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBmiCategory = new System.Windows.Forms.TextBox();
            this.lblBmiCategory = new System.Windows.Forms.Label();
            this.txtBmiValue = new System.Windows.Forms.TextBox();
            this.lblBmi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblBodyMassIndex = new System.Windows.Forms.Label();
            this.tsmiSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.基準値設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBmiCalculate
            // 
            this.btnBmiCalculate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBmiCalculate.Location = new System.Drawing.Point(226, 111);
            this.btnBmiCalculate.Name = "btnBmiCalculate";
            this.btnBmiCalculate.Size = new System.Drawing.Size(75, 34);
            this.btnBmiCalculate.TabIndex = 0;
            this.btnBmiCalculate.Text = "計算する";
            this.btnBmiCalculate.UseVisualStyleBackColor = true;
            this.btnBmiCalculate.Click += new System.EventHandler(this.BtnBMICalculate_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHeight.Location = new System.Drawing.Point(54, 16);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(40, 16);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "身長";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtHeight.Location = new System.Drawing.Point(100, 13);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(103, 23);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "0.0";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictToNumericInput);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtWeight.Location = new System.Drawing.Point(100, 52);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(103, 23);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Text = "0.0";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictToNumericInput);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWeight.Location = new System.Drawing.Point(54, 52);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(40, 16);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "体重";
            // 
            // lblCentimeter
            // 
            this.lblCentimeter.AutoSize = true;
            this.lblCentimeter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCentimeter.Location = new System.Drawing.Point(209, 16);
            this.lblCentimeter.Name = "lblCentimeter";
            this.lblCentimeter.Size = new System.Drawing.Size(28, 16);
            this.lblCentimeter.TabIndex = 6;
            this.lblCentimeter.Text = "cm";
            // 
            // lblKilogram
            // 
            this.lblKilogram.AutoSize = true;
            this.lblKilogram.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKilogram.Location = new System.Drawing.Point(209, 51);
            this.lblKilogram.Name = "lblKilogram";
            this.lblKilogram.Size = new System.Drawing.Size(22, 16);
            this.lblKilogram.TabIndex = 7;
            this.lblKilogram.Text = "kg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBmiCategory);
            this.groupBox1.Controls.Add(this.lblBmiCategory);
            this.groupBox1.Controls.Add(this.txtBmiValue);
            this.groupBox1.Controls.Add(this.lblBmi);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.btnBmiCalculate);
            this.groupBox1.Controls.Add(this.lblKilogram);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.lblCentimeter);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMIの計算";
            // 
            // txtBmiCategory
            // 
            this.txtBmiCategory.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBmiCategory.Location = new System.Drawing.Point(100, 122);
            this.txtBmiCategory.Name = "txtBmiCategory";
            this.txtBmiCategory.ReadOnly = true;
            this.txtBmiCategory.Size = new System.Drawing.Size(120, 23);
            this.txtBmiCategory.TabIndex = 11;
            this.txtBmiCategory.Text = "-";
            this.txtBmiCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBmiCategory
            // 
            this.lblBmiCategory.AutoSize = true;
            this.lblBmiCategory.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBmiCategory.Location = new System.Drawing.Point(6, 125);
            this.lblBmiCategory.Name = "lblBmiCategory";
            this.lblBmiCategory.Size = new System.Drawing.Size(88, 16);
            this.lblBmiCategory.TabIndex = 10;
            this.lblBmiCategory.Text = "肥満度判定";
            // 
            // txtBmiValue
            // 
            this.txtBmiValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBmiValue.Location = new System.Drawing.Point(100, 88);
            this.txtBmiValue.Name = "txtBmiValue";
            this.txtBmiValue.ReadOnly = true;
            this.txtBmiValue.Size = new System.Drawing.Size(120, 23);
            this.txtBmiValue.TabIndex = 9;
            this.txtBmiValue.Text = "-";
            this.txtBmiValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBmi.Location = new System.Drawing.Point(44, 91);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(50, 16);
            this.lblBmi.TabIndex = 8;
            this.lblBmi.Text = "BMI値";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblBodyMassIndex
            // 
            this.lblBodyMassIndex.AutoSize = true;
            this.lblBodyMassIndex.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBodyMassIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBodyMassIndex.Location = new System.Drawing.Point(59, 41);
            this.lblBodyMassIndex.Name = "lblBodyMassIndex";
            this.lblBodyMassIndex.Size = new System.Drawing.Size(193, 24);
            this.lblBodyMassIndex.TabIndex = 10;
            this.lblBodyMassIndex.Text = "Body Mass Index";
            // 
            // tsmiSetup
            // 
            this.tsmiSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基準値設定ToolStripMenuItem});
            this.tsmiSetup.Name = "tsmiSetup";
            this.tsmiSetup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmiSetup.Size = new System.Drawing.Size(60, 20);
            this.tsmiSetup.Text = "設定(&O)";
            // 
            // 基準値設定ToolStripMenuItem
            // 
            this.基準値設定ToolStripMenuItem.Name = "基準値設定ToolStripMenuItem";
            this.基準値設定ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.基準値設定ToolStripMenuItem.Text = "BMI基準値設定(&B)...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 259);
            this.Controls.Add(this.lblBodyMassIndex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(353, 298);
            this.Name = "FormMain";
            this.Text = "BMI 計算ツール";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBmiCalculate;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCentimeter;
        private System.Windows.Forms.Label lblKilogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBmiValue;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtBmiCategory;
        private System.Windows.Forms.Label lblBmiCategory;
        private System.Windows.Forms.Label lblBodyMassIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetup;
        private System.Windows.Forms.ToolStripMenuItem 基準値設定ToolStripMenuItem;
    }
}

