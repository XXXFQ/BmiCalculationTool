
namespace BmiCalculationTool.Forms
{
    partial class BmiThresholdEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nud_Thinness = new System.Windows.Forms.NumericUpDown();
            this.Nud_Obesity = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Thinness = new System.Windows.Forms.Label();
            this.Lbl_Obesity = new System.Windows.Forms.Label();
            this.Btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Thinness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Obesity)).BeginInit();
            this.SuspendLayout();
            // 
            // Nud_Thinness
            // 
            this.Nud_Thinness.DecimalPlaces = 1;
            this.Nud_Thinness.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nud_Thinness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_Thinness.Location = new System.Drawing.Point(130, 30);
            this.Nud_Thinness.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Nud_Thinness.Name = "Nud_Thinness";
            this.Nud_Thinness.Size = new System.Drawing.Size(86, 23);
            this.Nud_Thinness.TabIndex = 13;
            this.Nud_Thinness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Nud_Obesity
            // 
            this.Nud_Obesity.DecimalPlaces = 1;
            this.Nud_Obesity.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nud_Obesity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_Obesity.Location = new System.Drawing.Point(130, 63);
            this.Nud_Obesity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Nud_Obesity.Name = "Nud_Obesity";
            this.Nud_Obesity.Size = new System.Drawing.Size(86, 23);
            this.Nud_Obesity.TabIndex = 14;
            this.Nud_Obesity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lbl_Thinness
            // 
            this.Lbl_Thinness.AutoSize = true;
            this.Lbl_Thinness.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Thinness.Location = new System.Drawing.Point(26, 35);
            this.Lbl_Thinness.Name = "Lbl_Thinness";
            this.Lbl_Thinness.Size = new System.Drawing.Size(98, 14);
            this.Lbl_Thinness.TabIndex = 15;
            this.Lbl_Thinness.Text = "痩せすぎ基準値";
            // 
            // Lbl_Obesity
            // 
            this.Lbl_Obesity.AutoSize = true;
            this.Lbl_Obesity.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Obesity.Location = new System.Drawing.Point(27, 68);
            this.Lbl_Obesity.Name = "Lbl_Obesity";
            this.Lbl_Obesity.Size = new System.Drawing.Size(97, 14);
            this.Lbl_Obesity.TabIndex = 16;
            this.Lbl_Obesity.Text = "太り過ぎ基準値";
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Ok.Location = new System.Drawing.Point(212, 92);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(71, 27);
            this.Btn_Ok.TabIndex = 17;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // BmiThresholdEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 140);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Lbl_Obesity);
            this.Controls.Add(this.Lbl_Thinness);
            this.Controls.Add(this.Nud_Obesity);
            this.Controls.Add(this.Nud_Thinness);
            this.MaximizeBox = false;
            this.Name = "BmiThresholdEditor";
            this.Text = "BMI基準値設定";
            this.Load += new System.EventHandler(this.BmiThresholdEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Thinness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Obesity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Nud_Thinness;
        private System.Windows.Forms.NumericUpDown Nud_Obesity;
        private System.Windows.Forms.Label Lbl_Thinness;
        private System.Windows.Forms.Label Lbl_Obesity;
        private System.Windows.Forms.Button Btn_Ok;
    }
}