using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
 


    public partial class Indication : Form
    {
        decimal prevHVS;
        decimal prevGVS;
        decimal prevEnergyDay;
        decimal prevEnergyNight;
        public Indication()
        {
            InitializeComponent();
        }
        public void TransitionButton_Click(object sender, EventArgs e)
        {
            program val = new program(CountHVS.Value, CountGVS.Value, CountEnergyDay.Value, CountEnergyNight.Value, CountPeople.Value, HaveHVS.Checked, HaveGVS.Checked, HaveEnergy.Checked);
            prevHVS = CountHVS.Value;
            prevGVS = CountGVS.Value;
            prevEnergyDay = CountEnergyDay.Value;
            prevEnergyNight = CountEnergyNight.Value;
            HVS.Text = val.resHVS.ToString();
            GVS.Text = val.resGVS.ToString();
            EnergyDay.Text = val.resED.ToString();
            EnergyNight.Text = val.resEN.ToString();
            Summ.Text = val.summ.ToString();
        }

        private void HaveHVS_CheckedChanged(object sender, EventArgs e)
        {
            if (HaveHVS.Checked == true)
                CountHVS.Visible = true;
            else CountHVS.Visible = false;  
        }
        private void HaveGVS_CheckedChanged(object sender, EventArgs e)
        {
            if (HaveGVS.Checked == true)
                CountGVS.Visible = true;
            else CountGVS.Visible = false;
        }
        private void HaveEnergy_CheckedChanged(object sender, EventArgs e)
        {
            if (HaveEnergy.Checked == true)
            {
                CountEnergyDay.Visible = true;
                CountEnergyNight.Visible = true;
                Day.Visible = true;
                Night.Visible = true;
                CDay.Visible = true; 
                EnergyNight.Visible = true; 
                CNight.Visible = true;
            }
            else
            {
                CountEnergyDay.Visible = false;
                CountEnergyNight.Visible = false;
                Day.Visible = false;
                Night.Visible = false;
                CDay.Visible = false; 
                EnergyNight.Visible = false; 
                CNight.Visible = false;
            }
            }
        private void NextButton_Click(object sender, EventArgs e)
        {
            program val = new program(CountHVS.Value - prevHVS, CountGVS.Value - prevGVS, CountEnergyDay.Value - prevEnergyDay, CountEnergyNight.Value - prevEnergyNight, CountPeople.Value, HaveHVS.Checked, HaveGVS.Checked, HaveEnergy.Checked);
            prevHVS = CountHVS.Value;
            prevGVS = CountGVS.Value;
            prevEnergyDay = CountEnergyDay.Value;
            prevEnergyNight = CountEnergyNight.Value;
            HVS.Text = val.resHVS.ToString();
            GVS.Text = val.resGVS.ToString();
            EnergyDay.Text = val.resED.ToString();
            EnergyNight.Text = val.resEN.ToString();
            Summ.Text = val.summ.ToString();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            prevHVS = 0;
            prevGVS = 0;
            prevEnergyDay = 0;
            prevEnergyNight = 0;
            HVS.Text = "0";
            GVS.Text = "0";
            EnergyDay.Text = "0";
            EnergyNight.Text = "0";
            Summ.Text = "0";

        }

        Point lastPoint;
        private void Board_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Board_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
