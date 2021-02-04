using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//TODO добавить в программу ключи, для того чтобы при автоматической загрузки программа сама стартовала с ключами.

namespace ThreadingTimer
{
    public partial class Form1 : Form
    {
        //The Timer
        System.Threading.Timer theTimer = null;
        System.Threading.Timer WordWork = null;
        //Initialize information about the event
        //int.Parse(textBox1.Text);
        //int w = Convert.ToInt32();

        //private DateTime eventDate = new DateTime(2020, 12, 31);
        private DateTime eventDate;
        //
        int count = 0;

        new AutoBoot bootApp = new AutoBoot();



        public Form1(string[] args)
        {
            //TODO командная строка обработка 

            

            bootApp.NameSoft = "АвтоSave Word";
            InitializeComponent();

            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "с":
                        //Действие1;
                        System.Diagnostics.Debug.WriteLine("Circle");
                        // ...
                        break;
                    case "a":
                        //Действие2;
                        btnStartTimer_Click(null, null);
                        System.Diagnostics.Debug.WriteLine("AutoStart");
                        // ...
                        break;
                    default:
                        // ...
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            txtText.Text = Properties.Settings.Default.messages;

            txtDay.Text = Properties.Settings.Default.DayMessages.ToString();
            txtMount.Text = Properties.Settings.Default.MonthMessages.ToString();
            txtYear.Text = Properties.Settings.Default.YearMessages.ToString();
            txtHours.Text = Properties.Settings.Default.HourMessages.ToString();
            txtMin.Text = Properties.Settings.Default.MinutMessages.ToString();
            chkListBox.SetItemChecked(3, Properties.Settings.Default.EveryDay);




            //chkListBox.SetItemChecked(0, Properties.Settings.Default.AutoStart);
            chkListBox.SetItemChecked(0, bootApp.readReestrAutoBoot());
            chkListBox.SetItemChecked(1, Properties.Settings.Default.save);
            if (Properties.Settings.Default.save)
            {
                btnStartTimer_Click(null, null);
            }
            chkListBox.SetItemChecked(2, Properties.Settings.Default.visial);

            txtWordStart.Text = Properties.Settings.Default.StartTime.ToString();
            txtWordClose.Text = Properties.Settings.Default.CloseTime.ToString();

            

            

            //lblText.Text = txtText.Text;
            //eventDate = new DateTime(int.Parse(txtYear.Text), int.Parse(txtMount.Text), int.Parse(txtDay.Text));

            //theTimer = new System.Threading.Timer(this.Tick, null, 0, 1000);
            //WordWork = new System.Threading.Timer(this.TickWord, null, 0, 60000);

        }

        private void TickWord(object state)
        {
            System.Diagnostics.Debug.WriteLine("+"+txtWordStart+"мин");


            if (chkListBox.GetItemChecked(3))
            {
                
                TimeSpan tsStart = new TimeSpan(6, 00, 0);
                TimeSpan tsEnd = new TimeSpan(17, 00, 0);

                DateTime dtStart = DateTime.Today.Add(tsStart);
                DateTime dtEnd = DateTime.Today.Add(tsEnd);

                double dEndNow = (dtEnd - DateTime.Now).TotalSeconds;
                System.Diagnostics.Debug.WriteLine("Время до окночания рабочего дня " + dEndNow.ToString());
                double dStartNow = (DateTime.Now - dtStart).TotalSeconds;
                System.Diagnostics.Debug.WriteLine("Время c с начала рабочего дня " + dStartNow.ToString());

                
                if ((dtEnd - DateTime.Now).TotalSeconds > 1)
                {
                    if ((DateTime.Now - dtStart).TotalSeconds>1)
                    {
                        DataInWord inWord = new DataInWord();
                        bool visibleWord = chkListBox.GetItemChecked(2);
                        inWord.MyWord("test", false, visibleWord);

                        this.Invoke((Action)this.UpdateCountdownWord);
                    }

                    
                }
                
            }
            else
            {
                DataInWord inWord = new DataInWord();
                bool visibleWord = chkListBox.GetItemChecked(2);
                inWord.MyWord("test", false, visibleWord);

                this.Invoke((Action)this.UpdateCountdownWord);
            }

        }

        private void UpdateCountdownWord()
        {
            lblscan.Text = "";
            count = count + 1;
            lblContWordStart.Text = count.ToString();
        }

        private void Tick(object state)
        {
            
                this.Invoke((Action)this.UpdateCountdown); //выполняем в том же потоке.
            
            
        }

        private void UpdateCountdown()
        {
            TimeSpan remaining = eventDate - DateTime.Now ;


            if (remaining.TotalSeconds<1)
            {
                theTimer.Dispose();
                WordWork.Dispose();

                btnStartTimer.Enabled = true;

                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;

                
            }
            else
            {
                label1.Text = remaining.Days + " дней";
                label2.Text = remaining.Hours + " часов";
                label3.Text = remaining.Minutes + " минут";
                label4.Text = remaining.Seconds + " секунд";
                if (lblscan.Text=="")
                {
                    lblscan.Text = (int.Parse(txtWordStart.Text)*60).ToString();
                }
                else
                {
                    lblscan.Text = (int.Parse(lblscan.Text) - 1).ToString();
                }
                
            }

        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            lblText.Text = "До "+txtDay.Text+"."+txtMount.Text+"."+txtYear.Text+ " осталось:"  ;
            eventDate = new DateTime(int.Parse(txtYear.Text), int.Parse(txtMount.Text), int.Parse(txtDay.Text), 
                int.Parse(txtHours.Text), int.Parse(txtMin.Text), 0);
            DateTime dtNow = DateTime.Now;

            if ((eventDate.CompareTo(dtNow))<=0)
            {
                eventDate=dtNow.AddDays(+1);
                MessageBox.Show("Знаменательная дата меньше или равна текущей дате");
                
            }

            

            theTimer = new System.Threading.Timer(this.Tick, null, 0, 1000);
            //WordWork = new System.Threading.Timer(this.TickWord, null, 0, 60000);

           
            //ежедневная работа с Тнач до Тконц  
            
                WordWork = new System.Threading.Timer(this.TickWord, null, 0, int.Parse(txtWordStart.Text) * 60000);
            


            btnStartTimer.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.messages = txtText.Text;

            Properties.Settings.Default.DayMessages = int.Parse(txtDay.Text);
            Properties.Settings.Default.MonthMessages = int.Parse(txtMount.Text);
            Properties.Settings.Default.YearMessages = int.Parse(txtYear.Text);
            Properties.Settings.Default.HourMessages = int.Parse(txtHours.Text);
            Properties.Settings.Default.MinutMessages = int.Parse(txtMin.Text);
            Properties.Settings.Default.EveryDay = chkListBox.GetItemChecked(3);



            Properties.Settings.Default.StartTime = int.Parse(txtWordStart.Text);
            Properties.Settings.Default.CloseTime = int.Parse(txtWordClose.Text);

            if (bootApp.writeReestrAutoBoot(chkListBox.GetItemChecked(0)))
            {
                System.Diagnostics.Debug.WriteLine("Изменение прошло успешно");
                MessageBox.Show("Изменение прошло успешно");
            }
            
            
            
            

            Properties.Settings.Default.save = chkListBox.GetItemChecked(1);
            Properties.Settings.Default.visial = chkListBox.GetItemChecked(2);

            Properties.Settings.Default.Save();



        }

        private bool AutoSaveWindows()
        {
            try
            {
                //Если добавление в автозагрузку прошло без ошибок то return true;
                // а если с ошибкой то unCheck элемент
                

                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
            
        }

        private void chkListBox_Click(object sender, EventArgs e)
        {
            

            //// Display in a message box all the items that are checked.

            //// First show the index and check state of all selected items.
            //foreach (int indexChecked in chkListBox.CheckedIndices)
            //{
            //    // The indexChecked variable contains the index of the item.
            //    MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
            //                    chkListBox.GetItemCheckState(indexChecked).ToString() + ".");
            //}

            //// Next show the object title and check state for each item selected.
            //foreach (object itemChecked in chkListBox.CheckedItems)
            //{

            //    // Use the IndexOf method to get the index of an item.
            //    MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
            //                    "\", is checked. Checked state is: " +
            //                    chkListBox.GetItemCheckState(chkListBox.Items.IndexOf(itemChecked)).ToString() + ".");
            //}


            //if (chkListBox.GetItemCheckState(0) == CheckState.Unchecked)
            //{
            //    MessageBox.Show("Устанавливаем автозагрузку");
            //}

            //if (!chkListBox.GetItemChecked(0))
            //{
            //    MessageBox.Show("Устанавливаем автозагрузку");
            //}

        }

        private void chkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selected = chkListBox.SelectedIndex;
            //if (selected != -1)
            //{
            //    if (chkListBox.GetItemChecked(selected))
            //    {
            //        MessageBox.Show(chkListBox.Items[selected].ToString());
            //    }
                
            //}
        }

        
    }

}
