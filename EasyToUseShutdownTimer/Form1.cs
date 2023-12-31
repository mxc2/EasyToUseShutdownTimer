﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EasyToUseShutdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isTimerActive = Properties.Settings.Default.IsTimerActive;
            
            // Check if time has passed
            if (isTimerActive && checkIfSetTimerTimePassed(Properties.Settings.Default.timeToTimer))
            {
                Properties.Settings.Default.IsTimerActive = false;
            }

            // Add 10 minutes to current time
            dateTimePicker1.Value = DateTime.Now.AddMinutes(10);

            if (isTimerActive)
            {
                showActiveTimerScreen();
            }
            else
            {
                showMainScreen();
            }
        }

        private Boolean checkIfSetTimerTimePassed(DateTime dateTime)
        {
            // Get current datetime
            DateTime currentDateTime = DateTime.Now;

            // Return true if time passed
            if (currentDateTime > dateTime)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker1.Value;

            if (checkIfSetTimerTimePassed(selectedTime)) { 
                MessageBox.Show("Selected time is set in past. Please choose a time that is in the future."); 
                return; 
            }
            
            TimeSpan timeDifference = selectedTime - DateTime.Now;
            int seconds = (int)timeDifference.TotalSeconds;

            // Determine the selected action based on the radio button selection
            string action = "";
            if (radioButtonShutdown.Checked)
            {
                action = "shutdown";
                Process.Start("shutdown", $"/s /t {seconds}");
            }
            else if (radioButtonRestart.Checked)
            {
                action = "restart";
                Process.Start("shutdown", $"/r /t {seconds}");
            }
            else if (radioButtonHibernate.Checked)
            {
                action = "hibernate";
                Process.Start("shutdown", $"/h /t {seconds}");
            }

            if (!string.IsNullOrEmpty(action))
            {
                Properties.Settings.Default.IsTimerActive = true;
                Properties.Settings.Default.timeToTimer = selectedTime;
                Properties.Settings.Default.actionName = action;
                Properties.Settings.Default.Save();

                showActiveTimerScreen();
            }
            else
            {
                MessageBox.Show("Please select an action. In example: Shutdown.");
            }
        }

        private void buttonTimerCancel_Click(object sender, EventArgs e)
        {
            // Turn off shutdown
            Process.Start("shutdown", "-a");

            Properties.Settings.Default.IsTimerActive = false;
            Properties.Settings.Default.Save();

            showMainScreen();
        }

        private void showMainScreen()
        {
            groupBox2.Visible = false;
        }

        private void showActiveTimerScreen()
        {
            groupBox2.Visible = true;

            // Set the time when shutdown
            timeTillAction.Text = "Windows will " + Properties.Settings.Default.actionName;

            // Formats timeToTimer text
            DateTime timeToTimer = Properties.Settings.Default.timeToTimer;
            DateTime currentTime = DateTime.Now;

            if (timeToTimer.Day == currentTime.Day)
            {
                timeLabel.Text = timeToTimer.ToString("'Today at' HH:mm");
            }
            else if (timeToTimer.Day == currentTime.AddDays(1).Day)
            {
                timeLabel.Text = timeToTimer.ToString("'Tomorrow at' HH:mm");
            }
            else
            {
                timeLabel.Text = timeToTimer.ToString("'At' HH:mm 'on' dd. MMMM");
            }

            int groupBoxWidth = groupBox2.Width;
            CenterLabelHorizontally(timeTillAction, groupBoxWidth);
            CenterLabelHorizontally(timeLabel, groupBoxWidth);
        }

        void CenterLabelHorizontally(Label label, int containerWidth)
        {
            int labelWidth = label.Width;
            int labelX = (containerWidth - labelWidth) / 2;
            label.Location = new Point(labelX, label.Location.Y);
        }
    }
}
