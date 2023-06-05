using System;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            ThinnessThreshold = 17.5;
            ObesityThreshold = 25.0;
        }

        /// <summary>
        /// BMI値を算出してテキストに書き込む
        /// </summary>
        private void BtnBMICalculate_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(Nud_Height.Text) / 100;
            double weight = Convert.ToDouble(Nud_Weight.Text);
            Bmi bmi = new Bmi(height, weight);
            bmi.ChangeThresholds(ThinnessThreshold, ObesityThreshold);
            double bmiValue = Math.Round(bmi.BmiValue, 2, MidpointRounding.AwayFromZero);
            Txt_BmiValue.Text = bmiValue.ToString();
            Txt_BmiCategory.Text = bmi.GetBmiCategory();
        }

        /// <summary>
        /// BMI基準値設定フォームを開く
        /// </summary>
        private void TsmiBmiThresholdSetter_Click(object sender, EventArgs e)
        {
            BmiThresholdEditor bmiThresholdEditor = new BmiThresholdEditor();
            bmiThresholdEditor.Owner = this;
            bmiThresholdEditor.Closed += new EventHandler(SubFormClosed);
            bmiThresholdEditor.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// 子フォームが閉じられた時
        /// </summary>
        private void SubFormClosed(object sender, EventArgs e)
        {
            // 親フォーム自身の無効化を解除
            this.Enabled = true;
        }

        /// <summary>
        /// BMIの痩せすぎ基準値
        /// </summary>
        public double ThinnessThreshold { get; set; }

        /// <summary>
        /// BMIの太り過ぎ基準値
        /// </summary>
        public double ObesityThreshold { get; set; }
    }
}
