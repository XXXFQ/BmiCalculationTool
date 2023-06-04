using System;
using System.Linq;
using System.Windows.Forms;

using BmiCalculationTool.HealthCalculator;

namespace BmiCalculationTool.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// BMI値を算出してテキストに書き込む
        /// </summary>
        private void BtnBMICalculate_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtHeight.Text) / 100;
            double weight = Convert.ToDouble(txtWeight.Text);
            Bmi bmi = new Bmi(height, weight);
            double bmiValue = Math.Round(bmi.BmiValue, 2, MidpointRounding.AwayFromZero);
            txtBmiValue.Text = bmiValue.ToString();
            txtBmiCategory.Text = bmi.GetBmiCategory();
        }

        private void RestrictToNumericInput(object sender, KeyPressEventArgs e)
        {
            // バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b') return;

            // 数値0～9, ピリオド以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // ピリオドが既に入力されている場合は、さらにピリオドを入力させない
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
