using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HealthCalculator
{
    public partial class fmMain : Form
    {
        private float HandDin;
        private float WomanHeight;
        private float LungCapacity;
        private float Pressure;
        private float Pulse;
        private float RecoverySec;
        private float Weight;

        public fmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear()
        {
            tbHandDin.Clear();
            tbHeight.Clear();
            tbLungCapacity.Clear();
            tbPressure.Clear();
            tbPulse.Clear();
            tbRecoveryTime.Clear();
            tbWeight.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool ReadFields()
        {
             if (String.IsNullOrEmpty(tbHeight.Text) || !float.TryParse(tbHeight.Text, out WomanHeight))
            {
                tbHeight.Clear();
                MessageBox.Show("Укажите рост!");
                return false;
            }
            if (String.IsNullOrEmpty(tbWeight.Text) || !float.TryParse(tbWeight.Text, out Weight))
            {
                tbWeight.Clear();
                MessageBox.Show("Укажите вес!");
                return false;
            }
            if (String.IsNullOrEmpty(tbHandDin.Text) || !float.TryParse(tbHandDin.Text, out HandDin))
            {
                tbHandDin.Clear();
                MessageBox.Show("Укажите кистевую динамометрию!");
                return false;
            }
            if (String.IsNullOrEmpty(tbRecoveryTime.Text) || !float.TryParse(tbRecoveryTime.Text, out RecoverySec))
            {
                tbRecoveryTime.Clear();
                MessageBox.Show("Укажите время восстановления ЧСС!");
                return false;
            }
            if (String.IsNullOrEmpty(tbLungCapacity.Text) || !float.TryParse(tbLungCapacity.Text, out LungCapacity))
            {
                tbLungCapacity.Clear();
                MessageBox.Show("Укажите жизненную емкость легких!");
                return false;
            }
            if (String.IsNullOrEmpty(tbPulse.Text) || !float.TryParse(tbPulse.Text, out Pulse))
            {
                tbPulse.Clear();
                MessageBox.Show("Укажите ЧСС!");
                return false;
            }
            if (String.IsNullOrEmpty(tbPressure.Text) || !float.TryParse(tbPressure.Text, out Pressure))
            {
                tbPressure.Clear();
                MessageBox.Show("Укажите САД!");
                return false;
            }           
            return true;
        }

        private List<Result> Calculate()
        {
            List<Result> res = new List<Result>();
            Result KetleIndex = new Result();
            KetleIndex.Name = "Индекс Кетле";
            WomanHeight = WomanHeight / 100;
            KetleIndex.Res = Math.Round(Weight / Math.Pow(WomanHeight, 2),2);
            if (KetleIndex.Res >= 26.1)
            {
                KetleIndex.Level = LevelsConst.Low;
                KetleIndex.Mark = -2;
            }
            if (KetleIndex.Res >= 23.9 && KetleIndex.Res <= 26)
            {
                KetleIndex.Level = LevelsConst.BelowAverage;
                KetleIndex.Mark = -1;
            }
            if (KetleIndex.Res <= 23.8)
            {
                KetleIndex.Level = LevelsConst.Average;
                KetleIndex.Mark = 0;
            }
            res.Add(KetleIndex);
            Result PowerIndex = new Result();
            PowerIndex.Name = "Силовой индекс";
            PowerIndex.Res = Math.Round(HandDin * 100 / Weight,2);
            if (PowerIndex.Res <= 40) {
                PowerIndex.Level = LevelsConst.Low;
                PowerIndex.Mark = 0;
            }
            if (PowerIndex.Res <= 50 && PowerIndex.Res >= 41)
            {
                PowerIndex.Level = LevelsConst.BelowAverage;
                PowerIndex.Mark = 1;
            }
            if (PowerIndex.Res >= 51 && PowerIndex.Res <= 55) {
                PowerIndex.Level = LevelsConst.Average;
                PowerIndex.Mark = 2;
            }
            if (PowerIndex.Res >= 56 && PowerIndex.Res <= 60) {
                PowerIndex.Level = LevelsConst.AboveAverage;
                PowerIndex.Mark = 3;
            }
            if (PowerIndex.Res >= 61) {
                PowerIndex.Level = LevelsConst.High;
                PowerIndex.Mark = 4;
            }
            res.Add(PowerIndex);
            Result LifeIndex = new Result();
            LifeIndex.Name = "Жизненный индекс";
            LifeIndex.Res = Math.Round(LungCapacity / Weight,2); 
            if (LifeIndex.Res <= 40)
            {
                LifeIndex.Level = LevelsConst.Low;
                LifeIndex.Mark = 0;
            }
            if (LifeIndex.Res <= 45 && LifeIndex.Res >= 41)
            {
                LifeIndex.Level = LevelsConst.BelowAverage;
                LifeIndex.Mark = 1;
            }
            if (LifeIndex.Res >= 46 && LifeIndex.Res <= 50)
            {
                LifeIndex.Level = LevelsConst.Average;
                LifeIndex.Mark = 2;
            }
            if (LifeIndex.Res >= 51 && LifeIndex.Res <= 55)
            {
                LifeIndex.Level = LevelsConst.AboveAverage;
                LifeIndex.Mark = 4;
            }
            if (LifeIndex.Res >= 56)
            {
                LifeIndex.Level = LevelsConst.High;
                LifeIndex.Mark = 5;
            }
            res.Add(LifeIndex);
            Result RobinsonIndex = new Result();
            RobinsonIndex.Name = "Индекс Робинсона";
            RobinsonIndex.Res = Math.Round(Pulse * Pressure / 100,2);
            if (RobinsonIndex.Res >= 111)
            {
                RobinsonIndex.Level = LevelsConst.Low;
                RobinsonIndex.Mark = -2;
            }
            if (RobinsonIndex.Res <= 110 && RobinsonIndex.Res >= 95)
            {
                RobinsonIndex.Level = LevelsConst.BelowAverage;
                RobinsonIndex.Mark = 0;
            }
            if (RobinsonIndex.Res >= 85 && RobinsonIndex.Res <= 94)
            {
                RobinsonIndex.Level = LevelsConst.Average;
                RobinsonIndex.Mark = 2;
            }
            if (RobinsonIndex.Res >= 70 && RobinsonIndex.Res <= 84)
            {
                RobinsonIndex.Level = LevelsConst.AboveAverage;
                RobinsonIndex.Mark = 3;
            }
            if (RobinsonIndex.Res <= 69)
            {
                RobinsonIndex.Level = LevelsConst.High;
                RobinsonIndex.Mark = 4;
            }
            res.Add(RobinsonIndex);
            Result Recovery = new Result();
            Recovery.Name = "Время восстановления ЧСС";
            Recovery.Res = RecoverySec;
            if (Recovery.Res >= 180)
            {
                Recovery.Level = LevelsConst.Low;
                Recovery.Mark = -2;
            }
            if (Recovery.Res <= 179 && Recovery.Res >= 120)
            {
                Recovery.Level = LevelsConst.BelowAverage;
                Recovery.Mark = 1;
            }
            if (Recovery.Res >= 90 && Recovery.Res <= 119)
            {
                Recovery.Level = LevelsConst.Average;
                Recovery.Mark = 3;
            }
            if (Recovery.Res >= 60 && Recovery.Res <= 89)
            {
                Recovery.Level = LevelsConst.AboveAverage;
                Recovery.Mark = 5;
            }
            if (Recovery.Res <= 59)
            {
                Recovery.Level = LevelsConst.High;
                Recovery.Mark = 7;
            }
            res.Add(Recovery);
            Result r = new Result();
            r.Name = "Общий уровень здоровья";
            r.Mark = KetleIndex.Mark + LifeIndex.Mark + RobinsonIndex.Mark + PowerIndex.Mark + Recovery.Mark;
            if (r.Mark <= 4) r.Level = LevelsConst.Low;
            if (r.Mark >= 5 && r.Mark <= 9) r.Level = LevelsConst.BelowAverage;
            if (r.Mark >= 10 && r.Mark <= 13) r.Level = LevelsConst.Average;
            if (r.Mark >= 14 && r.Mark <= 16) r.Level = LevelsConst.AboveAverage;
            if (r.Mark  >= 17 && r.Mark <= 21) r.Level = LevelsConst.High;
            res.Add(r);
            return res;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ReadFields())
            {
                fmResult f = new fmResult(Calculate());
                f.ShowDialog();
            }
        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
        }
    }
}
