
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
            this.Btn_BmiCalculate = new System.Windows.Forms.Button();
            this.Lbl_Height = new System.Windows.Forms.Label();
            this.Lbl_Weight = new System.Windows.Forms.Label();
            this.Lbl_Centimeter = new System.Windows.Forms.Label();
            this.Lbl_Kilogram = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nud_Weight = new System.Windows.Forms.NumericUpDown();
            this.Nud_Height = new System.Windows.Forms.NumericUpDown();
            this.Txt_BmiCategory = new System.Windows.Forms.TextBox();
            this.Lbl_BmiCategory = new System.Windows.Forms.Label();
            this.Txt_BmiValue = new System.Windows.Forms.TextBox();
            this.Lbl_Bmi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsmi_Setup = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_BmiThresholdEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_BodyMassIndex = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Height)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_BmiCalculate
            // 
            this.Btn_BmiCalculate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_BmiCalculate.Location = new System.Drawing.Point(226, 111);
            this.Btn_BmiCalculate.Name = "Btn_BmiCalculate";
            this.Btn_BmiCalculate.Size = new System.Drawing.Size(75, 34);
            this.Btn_BmiCalculate.TabIndex = 0;
            this.Btn_BmiCalculate.Text = "計算する";
            this.Btn_BmiCalculate.UseVisualStyleBackColor = true;
            this.Btn_BmiCalculate.Click += new System.EventHandler(this.BtnBMICalculate_Click);
            // 
            // Lbl_Height
            // 
            this.Lbl_Height.AutoSize = true;
            this.Lbl_Height.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Height.Location = new System.Drawing.Point(54, 16);
            this.Lbl_Height.Name = "Lbl_Height";
            this.Lbl_Height.Size = new System.Drawing.Size(40, 16);
            this.Lbl_Height.TabIndex = 1;
            this.Lbl_Height.Text = "身長";
            // 
            // Lbl_Weight
            // 
            this.Lbl_Weight.AutoSize = true;
            this.Lbl_Weight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Weight.Location = new System.Drawing.Point(54, 52);
            this.Lbl_Weight.Name = "Lbl_Weight";
            this.Lbl_Weight.Size = new System.Drawing.Size(40, 16);
            this.Lbl_Weight.TabIndex = 5;
            this.Lbl_Weight.Text = "体重";
            // 
            // Lbl_Centimeter
            // 
            this.Lbl_Centimeter.AutoSize = true;
            this.Lbl_Centimeter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Centimeter.Location = new System.Drawing.Point(209, 16);
            this.Lbl_Centimeter.Name = "Lbl_Centimeter";
            this.Lbl_Centimeter.Size = new System.Drawing.Size(28, 16);
            this.Lbl_Centimeter.TabIndex = 6;
            this.Lbl_Centimeter.Text = "cm";
            // 
            // Lbl_Kilogram
            // 
            this.Lbl_Kilogram.AutoSize = true;
            this.Lbl_Kilogram.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Kilogram.Location = new System.Drawing.Point(209, 51);
            this.Lbl_Kilogram.Name = "Lbl_Kilogram";
            this.Lbl_Kilogram.Size = new System.Drawing.Size(22, 16);
            this.Lbl_Kilogram.TabIndex = 7;
            this.Lbl_Kilogram.Text = "kg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nud_Weight);
            this.groupBox1.Controls.Add(this.Nud_Height);
            this.groupBox1.Controls.Add(this.Txt_BmiCategory);
            this.groupBox1.Controls.Add(this.Lbl_BmiCategory);
            this.groupBox1.Controls.Add(this.Txt_BmiValue);
            this.groupBox1.Controls.Add(this.Lbl_Bmi);
            this.groupBox1.Controls.Add(this.Lbl_Weight);
            this.groupBox1.Controls.Add(this.Btn_BmiCalculate);
            this.groupBox1.Controls.Add(this.Lbl_Kilogram);
            this.groupBox1.Controls.Add(this.Lbl_Height);
            this.groupBox1.Controls.Add(this.Lbl_Centimeter);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMIの計算";
            // 
            // Nud_Weight
            // 
            this.Nud_Weight.DecimalPlaces = 1;
            this.Nud_Weight.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nud_Weight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_Weight.Location = new System.Drawing.Point(100, 49);
            this.Nud_Weight.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.Nud_Weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Weight.Name = "Nud_Weight";
            this.Nud_Weight.Size = new System.Drawing.Size(103, 23);
            this.Nud_Weight.TabIndex = 13;
            this.Nud_Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Nud_Weight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Nud_Height
            // 
            this.Nud_Height.DecimalPlaces = 1;
            this.Nud_Height.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nud_Height.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_Height.Location = new System.Drawing.Point(100, 14);
            this.Nud_Height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Nud_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Height.Name = "Nud_Height";
            this.Nud_Height.Size = new System.Drawing.Size(103, 23);
            this.Nud_Height.TabIndex = 12;
            this.Nud_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Nud_Height.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // Txt_BmiCategory
            // 
            this.Txt_BmiCategory.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_BmiCategory.Location = new System.Drawing.Point(100, 122);
            this.Txt_BmiCategory.Name = "Txt_BmiCategory";
            this.Txt_BmiCategory.ReadOnly = true;
            this.Txt_BmiCategory.Size = new System.Drawing.Size(120, 23);
            this.Txt_BmiCategory.TabIndex = 11;
            this.Txt_BmiCategory.Text = "-";
            this.Txt_BmiCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_BmiCategory
            // 
            this.Lbl_BmiCategory.AutoSize = true;
            this.Lbl_BmiCategory.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_BmiCategory.Location = new System.Drawing.Point(6, 125);
            this.Lbl_BmiCategory.Name = "Lbl_BmiCategory";
            this.Lbl_BmiCategory.Size = new System.Drawing.Size(88, 16);
            this.Lbl_BmiCategory.TabIndex = 10;
            this.Lbl_BmiCategory.Text = "肥満度判定";
            // 
            // Txt_BmiValue
            // 
            this.Txt_BmiValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_BmiValue.Location = new System.Drawing.Point(100, 88);
            this.Txt_BmiValue.Name = "Txt_BmiValue";
            this.Txt_BmiValue.ReadOnly = true;
            this.Txt_BmiValue.Size = new System.Drawing.Size(120, 23);
            this.Txt_BmiValue.TabIndex = 9;
            this.Txt_BmiValue.Text = "-";
            this.Txt_BmiValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Bmi
            // 
            this.Lbl_Bmi.AutoSize = true;
            this.Lbl_Bmi.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Bmi.Location = new System.Drawing.Point(44, 91);
            this.Lbl_Bmi.Name = "Lbl_Bmi";
            this.Lbl_Bmi.Size = new System.Drawing.Size(50, 16);
            this.Lbl_Bmi.TabIndex = 8;
            this.Lbl_Bmi.Text = "BMI値";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Setup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsmi_Setup
            // 
            this.Tsmi_Setup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_BmiThresholdEditor});
            this.Tsmi_Setup.Name = "Tsmi_Setup";
            this.Tsmi_Setup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.Tsmi_Setup.Size = new System.Drawing.Size(60, 20);
            this.Tsmi_Setup.Text = "設定(&O)";
            // 
            // Tsmi_BmiThresholdEditor
            // 
            this.Tsmi_BmiThresholdEditor.Name = "Tsmi_BmiThresholdEditor";
            this.Tsmi_BmiThresholdEditor.Size = new System.Drawing.Size(180, 22);
            this.Tsmi_BmiThresholdEditor.Text = "BMI基準値設定(&B)...";
            this.Tsmi_BmiThresholdEditor.Click += new System.EventHandler(this.TsmiBmiThresholdSetter_Click);
            // 
            // Lbl_BodyMassIndex
            // 
            this.Lbl_BodyMassIndex.AutoSize = true;
            this.Lbl_BodyMassIndex.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_BodyMassIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbl_BodyMassIndex.Location = new System.Drawing.Point(59, 41);
            this.Lbl_BodyMassIndex.Name = "Lbl_BodyMassIndex";
            this.Lbl_BodyMassIndex.Size = new System.Drawing.Size(193, 24);
            this.Lbl_BodyMassIndex.TabIndex = 10;
            this.Lbl_BodyMassIndex.Text = "Body Mass Index";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 259);
            this.Controls.Add(this.Lbl_BodyMassIndex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(353, 298);
            this.Name = "FormMain";
            this.Text = "BMI 計算ツール";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Height)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_BmiCalculate;
        private System.Windows.Forms.Label Lbl_Height;
        private System.Windows.Forms.Label Lbl_Weight;
        private System.Windows.Forms.Label Lbl_Centimeter;
        private System.Windows.Forms.Label Lbl_Kilogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_BmiValue;
        private System.Windows.Forms.Label Lbl_Bmi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox Txt_BmiCategory;
        private System.Windows.Forms.Label Lbl_BmiCategory;
        private System.Windows.Forms.Label Lbl_BodyMassIndex;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Setup;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_BmiThresholdEditor;
        private System.Windows.Forms.NumericUpDown Nud_Height;
        private System.Windows.Forms.NumericUpDown Nud_Weight;
    }
}

