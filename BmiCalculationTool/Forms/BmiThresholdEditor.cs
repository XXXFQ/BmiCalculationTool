using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmiCalculationTool.Forms
{
    public partial class BmiThresholdEditor : Form
    {
        private FormMain formMain;

        public BmiThresholdEditor()
        {
            InitializeComponent();
        }

        private void BmiThresholdEditor_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;

            if (formMain != null)
            {
                Nud_Thinness.Value = Convert.ToDecimal(formMain.ThinnessThreshold);
                Nud_Obesity.Value = Convert.ToDecimal(formMain.ObesityThreshold);
            }
        }

        /// <summary>
        /// 設定を保存してフォームを閉じる
        /// </summary>
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (formMain != null)
            {
                formMain.ThinnessThreshold = Convert.ToDouble(Nud_Thinness.Value);
                formMain.ObesityThreshold = Convert.ToDouble(Nud_Obesity.Value);
            }
            this.Close();
        }
    }
}
