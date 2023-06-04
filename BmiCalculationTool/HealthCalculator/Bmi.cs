using System;

namespace BmiCalculationTool.HealthCalculator
{
    internal class Bmi
    {
        private double _thinnessThreshold = 17.5;
        private double _obesityThreshold = 25.0;

        public Bmi(double height, double weight)
        {
            this.Height = height;
            this.Weight = weight;
        }

        /// <summary>
        /// BMIのカテゴリを取得する
        /// </summary>
        public string GetBmiCategory()
        {
            if (BmiValue < _thinnessThreshold) return "痩せすぎです";
            if (BmiValue >= _obesityThreshold) return "太り過ぎです";
            return "適正範囲です";
        }

        /// <summary>
        /// BMIの肥満度判定の閾値を変更する
        /// </summary>
        /// <param name="thinness">痩せすぎ基準値</param>
        /// <param name="obesity">太り過ぎ基準値</param>
        public void ChangeThresholds(double thinness, double obesity)
        {
            if (thinness >= obesity) throw new ArgumentOutOfRangeException();

            this._thinnessThreshold = thinness;
            this._obesityThreshold = obesity;
        }

        /// <summary>
        /// 身長(m)の設定、取得
        /// </summary>
        /// <returns>身長(m)</returns>
        public double Height { get; }

        /// <summary>
        /// 体重(kg)の設定、取得
        /// </summary>
        /// <returns>体重(kg)</returns>
        public double Weight { get; }

        /// <summary>
        /// BMI値を算出して取得する
        /// </summary>
        /// <returns>BMI値</returns>
        public double BmiValue => this.Weight / Math.Pow(this.Height, 2);
    }
}
