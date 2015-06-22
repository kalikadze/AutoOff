using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoOff
{

    public partial class Auto_Off_Form : Form
    {
        bool first_tick = true;
        DateTime time_abs = DateTime.Now, current;
        TimeSpan time_rel;

        public Auto_Off_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker1.CustomFormat = "HH:mm:ss dd.MM.yyyy";
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker2.Value = DateTime.Today.AddYears(-100);
            toolTip1.SetToolTip(dateTimePicker1, "Pick date by clicking on the arrrow. Pick desired date.\n" +
                                                 "Or you may keep it (today) and change just a time by clicking\n" +
                                                 "on the hours, minutes, seconds. You may directly insert desired\n" +
                                                 "value or use arrows up/downs.");
            toolTip2.SetToolTip(dateTimePicker2, "Pick date by clicking on the arrrow. Pick desired date.\n" +
                                                 "Or you may keep it (today) and change just a time by clicking\n" +
                                                 "on the hours, minutes, seconds. You may directly insert desired\n" +
                                                 "value or use arrows up/downs.");

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            first_tick = true;
            main_timer.Enabled = true;
            button_stop.Enabled = true;
            button_start.Enabled = false;
            tabControl1.Enabled = false;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            first_tick = false;
            main_timer.Enabled = false;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            tabControl1.Enabled = true;
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            int cmp_result = 0;
        
                        
            // result of absolute
            if (tabControl1.SelectedTab == tabControl1.TabPages["absolute"])
            {
                if (first_tick)
                {
                    time_abs = dateTimePicker1.Value;
                    current = DateTime.Now;
                    first_tick = false;
                }                
            }

            // result of relative
            if (tabControl1.SelectedTab == tabControl1.TabPages["relative"])
            {
                if (first_tick)
                {
                    time_rel = new TimeSpan(dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
                    time_abs = DateTime.Now.Add(time_rel);
                    first_tick = false;
                }                
            }

            current = DateTime.Now;
            cmp_result = DateTime.Compare(time_abs, current);

            if (cmp_result <= 0)
            {
                // off
                if (radioButton1_TO.Checked || radioButton8_TO.Checked)
                {
                    var psi = new ProcessStartInfo("shutdown","/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);                
                }

                // sleep & standby
                if (radioButton2_S.Checked || radioButton7_S.Checked)
                {
                    Application.SetSuspendState(PowerState.Suspend, true, true);  
                }
                
                // hibernate
                if (radioButton3_H.Checked || radioButton6_H.Checked)
                {
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                }
                // restart
                if (radioButton4_R.Checked || radioButton5_R.Checked)
                {
                    var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                }                
            }
        }
    }
}
