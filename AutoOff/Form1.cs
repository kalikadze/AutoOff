using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoOff
{

    public partial class Auto_Off_Form : Form
    {    
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
            toolTip2.SetToolTip(dateTimePicker1, "Pick date by clicking on the arrrow. Pick desired date.\n" +
                                                 "Or you may keep it (today) and change just a time by clicking\n" +
                                                 "on the hours, minutes, seconds. You may directly insert desired\n" +
                                                 "value or use arrows up/downs.");

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            main_timer.Enabled = true;
            button_stop.Enabled = true;
            button_start.Enabled = false;
            tabControl1.Enabled = false;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            main_timer.Enabled = false;
            button_start.Enabled = true;
            button_stop.Enabled = false;
            tabControl1.Enabled = true;
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["absolute"])
            { 
            
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["relative"])
            {

            }
        }
    }
}
