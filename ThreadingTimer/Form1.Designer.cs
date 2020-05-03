namespace ThreadingTimer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblContWordStart = new System.Windows.Forms.Label();
            this.tabPersonalData = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.lblCountWord = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtWordClose = new System.Windows.Forms.TextBox();
            this.txtWordStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMount = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPersonalData.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContWordStart
            // 
            this.lblContWordStart.AutoSize = true;
            this.lblContWordStart.Location = new System.Drawing.Point(165, 179);
            this.lblContWordStart.Name = "lblContWordStart";
            this.lblContWordStart.Size = new System.Drawing.Size(0, 13);
            this.lblContWordStart.TabIndex = 6;
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Controls.Add(this.tabData);
            this.tabPersonalData.Controls.Add(this.tabSetting);
            this.tabPersonalData.Location = new System.Drawing.Point(2, 2);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.SelectedIndex = 0;
            this.tabPersonalData.Size = new System.Drawing.Size(385, 254);
            this.tabPersonalData.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabPersonalData.TabIndex = 7;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.btnStartTimer);
            this.tabData.Controls.Add(this.lblCountWord);
            this.tabData.Controls.Add(this.lblContWordStart);
            this.tabData.Controls.Add(this.lblText);
            this.tabData.Controls.Add(this.label4);
            this.tabData.Controls.Add(this.label3);
            this.tabData.Controls.Add(this.label2);
            this.tabData.Controls.Add(this.label1);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(377, 228);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Осталось";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(3, 202);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(367, 23);
            this.btnStartTimer.TabIndex = 12;
            this.btnStartTimer.Text = "Старт счетчика ";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // lblCountWord
            // 
            this.lblCountWord.AutoSize = true;
            this.lblCountWord.Location = new System.Drawing.Point(39, 179);
            this.lblCountWord.Name = "lblCountWord";
            this.lblCountWord.Size = new System.Drawing.Size(120, 13);
            this.lblCountWord.TabIndex = 11;
            this.lblCountWord.Text = "Кол-во запусков Word";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(18, 21);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(299, 26);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "до Нового Года осталось:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Секунд";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Минут";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Часов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дней";
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.txtMin);
            this.tabSetting.Controls.Add(this.label9);
            this.tabSetting.Controls.Add(this.txtHours);
            this.tabSetting.Controls.Add(this.txtWordClose);
            this.tabSetting.Controls.Add(this.txtWordStart);
            this.tabSetting.Controls.Add(this.label8);
            this.tabSetting.Controls.Add(this.label7);
            this.tabSetting.Controls.Add(this.btnSave);
            this.tabSetting.Controls.Add(this.label6);
            this.tabSetting.Controls.Add(this.label5);
            this.tabSetting.Controls.Add(this.txtDay);
            this.tabSetting.Controls.Add(this.txtMount);
            this.tabSetting.Controls.Add(this.txtYear);
            this.tabSetting.Controls.Add(this.txtText);
            this.tabSetting.Controls.Add(this.chkListBox);
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(377, 228);
            this.tabSetting.TabIndex = 1;
            this.tabSetting.Text = "Настройка";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(202, 26);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(25, 20);
            this.txtMin.TabIndex = 14;
            this.txtMin.Text = "15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = ":";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(158, 26);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(22, 20);
            this.txtHours.TabIndex = 12;
            this.txtHours.Text = "15";
            // 
            // txtWordClose
            // 
            this.txtWordClose.Location = new System.Drawing.Point(205, 164);
            this.txtWordClose.Name = "txtWordClose";
            this.txtWordClose.Size = new System.Drawing.Size(25, 20);
            this.txtWordClose.TabIndex = 11;
            this.txtWordClose.Text = "1";
            // 
            // txtWordStart
            // 
            this.txtWordStart.Location = new System.Drawing.Point(205, 144);
            this.txtWordStart.Name = "txtWordStart";
            this.txtWordStart.Size = new System.Drawing.Size(25, 20);
            this.txtWordStart.TabIndex = 10;
            this.txtWordStart.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Через сколько запускать Word, мин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Через сколько закрывать Word, мин";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(377, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить настройки.";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = ".";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(3, 26);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(22, 20);
            this.txtDay.TabIndex = 4;
            this.txtDay.Text = "31";
            // 
            // txtMount
            // 
            this.txtMount.Location = new System.Drawing.Point(44, 26);
            this.txtMount.Name = "txtMount";
            this.txtMount.Size = new System.Drawing.Size(25, 20);
            this.txtMount.TabIndex = 3;
            this.txtMount.Text = "12";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(91, 26);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(36, 20);
            this.txtYear.TabIndex = 2;
            this.txtYear.Text = "2021";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(377, 20);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "До 2022 осталось:";
            // 
            // chkListBox
            // 
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Items.AddRange(new object[] {
            "АвтоЗагрузка при запуске Windows",
            "АвтоСтарт при запуске программы",
            "Word visible",
            "Ежедневное напоминание"});
            this.chkListBox.Location = new System.Drawing.Point(0, 52);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(377, 79);
            this.chkListBox.TabIndex = 0;
            this.chkListBox.Click += new System.EventHandler(this.chkListBox_Click);
            this.chkListBox.SelectedIndexChanged += new System.EventHandler(this.chkListBox_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 255);
            this.Controls.Add(this.tabPersonalData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Знаменательная дата";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPersonalData.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblContWordStart;
        private System.Windows.Forms.TabControl tabPersonalData;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.Label lblCountWord;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMount;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWordClose;
        private System.Windows.Forms.TextBox txtWordStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHours;
    }
}

