namespace AutoOff
{
    partial class Auto_Off_Form
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
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.absolute = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4_R = new System.Windows.Forms.RadioButton();
            this.radioButton3_H = new System.Windows.Forms.RadioButton();
            this.radioButton2_S = new System.Windows.Forms.RadioButton();
            this.radioButton1_TO = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.relative = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5_R = new System.Windows.Forms.RadioButton();
            this.radioButton6_H = new System.Windows.Forms.RadioButton();
            this.radioButton7_S = new System.Windows.Forms.RadioButton();
            this.radioButton8_TO = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.absolute.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.relative.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(224, 22);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(64, 70);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(224, 98);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(64, 70);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.absolute);
            this.tabControl1.Controls.Add(this.relative);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 174);
            this.tabControl1.TabIndex = 0;
            // 
            // absolute
            // 
            this.absolute.Controls.Add(this.groupBox1);
            this.absolute.Controls.Add(this.dateTimePicker1);
            this.absolute.Location = new System.Drawing.Point(4, 22);
            this.absolute.Name = "absolute";
            this.absolute.Padding = new System.Windows.Forms.Padding(3);
            this.absolute.Size = new System.Drawing.Size(214, 148);
            this.absolute.TabIndex = 0;
            this.absolute.Text = "Turn Off:";
            this.absolute.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4_R);
            this.groupBox1.Controls.Add(this.radioButton3_H);
            this.groupBox1.Controls.Add(this.radioButton2_S);
            this.groupBox1.Controls.Add(this.radioButton1_TO);
            this.groupBox1.Location = new System.Drawing.Point(8, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // radioButton4_R
            // 
            this.radioButton4_R.AutoSize = true;
            this.radioButton4_R.Location = new System.Drawing.Point(6, 88);
            this.radioButton4_R.Name = "radioButton4_R";
            this.radioButton4_R.Size = new System.Drawing.Size(59, 17);
            this.radioButton4_R.TabIndex = 2;
            this.radioButton4_R.Text = "Restart";
            this.radioButton4_R.UseVisualStyleBackColor = true;
            // 
            // radioButton3_H
            // 
            this.radioButton3_H.AutoSize = true;
            this.radioButton3_H.Location = new System.Drawing.Point(6, 65);
            this.radioButton3_H.Name = "radioButton3_H";
            this.radioButton3_H.Size = new System.Drawing.Size(71, 17);
            this.radioButton3_H.TabIndex = 2;
            this.radioButton3_H.Text = "Hibernate";
            this.radioButton3_H.UseVisualStyleBackColor = true;
            // 
            // radioButton2_S
            // 
            this.radioButton2_S.AutoSize = true;
            this.radioButton2_S.Location = new System.Drawing.Point(6, 42);
            this.radioButton2_S.Name = "radioButton2_S";
            this.radioButton2_S.Size = new System.Drawing.Size(52, 17);
            this.radioButton2_S.TabIndex = 2;
            this.radioButton2_S.Text = "Sleep";
            this.radioButton2_S.UseVisualStyleBackColor = true;
            // 
            // radioButton1_TO
            // 
            this.radioButton1_TO.AutoSize = true;
            this.radioButton1_TO.Checked = true;
            this.radioButton1_TO.Location = new System.Drawing.Point(6, 19);
            this.radioButton1_TO.Name = "radioButton1_TO";
            this.radioButton1_TO.Size = new System.Drawing.Size(64, 17);
            this.radioButton1_TO.TabIndex = 2;
            this.radioButton1_TO.TabStop = true;
            this.radioButton1_TO.Text = "Turn Off";
            this.radioButton1_TO.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // relative
            // 
            this.relative.Controls.Add(this.groupBox2);
            this.relative.Controls.Add(this.dateTimePicker2);
            this.relative.Location = new System.Drawing.Point(4, 22);
            this.relative.Name = "relative";
            this.relative.Padding = new System.Windows.Forms.Padding(3);
            this.relative.Size = new System.Drawing.Size(214, 148);
            this.relative.TabIndex = 1;
            this.relative.Text = "Turn Off in:";
            this.relative.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5_R);
            this.groupBox2.Controls.Add(this.radioButton6_H);
            this.groupBox2.Controls.Add(this.radioButton7_S);
            this.groupBox2.Controls.Add(this.radioButton8_TO);
            this.groupBox2.Location = new System.Drawing.Point(8, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // radioButton5_R
            // 
            this.radioButton5_R.AutoSize = true;
            this.radioButton5_R.Location = new System.Drawing.Point(6, 88);
            this.radioButton5_R.Name = "radioButton5_R";
            this.radioButton5_R.Size = new System.Drawing.Size(59, 17);
            this.radioButton5_R.TabIndex = 3;
            this.radioButton5_R.Text = "Restart";
            this.radioButton5_R.UseVisualStyleBackColor = true;
            // 
            // radioButton6_H
            // 
            this.radioButton6_H.AutoSize = true;
            this.radioButton6_H.Location = new System.Drawing.Point(6, 65);
            this.radioButton6_H.Name = "radioButton6_H";
            this.radioButton6_H.Size = new System.Drawing.Size(71, 17);
            this.radioButton6_H.TabIndex = 4;
            this.radioButton6_H.Text = "Hibernate";
            this.radioButton6_H.UseVisualStyleBackColor = true;
            // 
            // radioButton7_S
            // 
            this.radioButton7_S.AutoSize = true;
            this.radioButton7_S.Location = new System.Drawing.Point(6, 42);
            this.radioButton7_S.Name = "radioButton7_S";
            this.radioButton7_S.Size = new System.Drawing.Size(52, 17);
            this.radioButton7_S.TabIndex = 5;
            this.radioButton7_S.Text = "Sleep";
            this.radioButton7_S.UseVisualStyleBackColor = true;
            // 
            // radioButton8_TO
            // 
            this.radioButton8_TO.AutoSize = true;
            this.radioButton8_TO.Checked = true;
            this.radioButton8_TO.Location = new System.Drawing.Point(6, 19);
            this.radioButton8_TO.Name = "radioButton8_TO";
            this.radioButton8_TO.Size = new System.Drawing.Size(64, 17);
            this.radioButton8_TO.TabIndex = 6;
            this.radioButton8_TO.TabStop = true;
            this.radioButton8_TO.Text = "Turn Off";
            this.radioButton8_TO.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // main_timer
            // 
            this.main_timer.Interval = 500;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // Auto_Off_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 186);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.tabControl1);
            this.Name = "Auto_Off_Form";
            this.Text = "AutOff";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.absolute.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.relative.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage absolute;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage relative;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4_R;
        private System.Windows.Forms.RadioButton radioButton3_H;
        private System.Windows.Forms.RadioButton radioButton2_S;
        private System.Windows.Forms.RadioButton radioButton1_TO;
        private System.Windows.Forms.RadioButton radioButton5_R;
        private System.Windows.Forms.RadioButton radioButton6_H;
        private System.Windows.Forms.RadioButton radioButton7_S;
        private System.Windows.Forms.RadioButton radioButton8_TO;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;

    }
}

