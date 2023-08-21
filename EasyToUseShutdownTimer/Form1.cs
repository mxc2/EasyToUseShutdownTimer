﻿using System;
using System.Diagnostics;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker1.Value;
            TimeSpan timeDifference = selectedTime - DateTime.Now;
            int seconds = (int)timeDifference.TotalSeconds;

            // Determine the selected action based on the radio button selection
            string action = "";
            if (radioButtonShutdown.Checked)
            {
                action = "shutdown";  // Shutdown
                Process.Start("shutdown", $"/s /t {seconds}");
            }
            else if (radioButtonRestart.Checked)
            {
                action = "restart";  // Restart
                Process.Start("shutdown", $"/r /t {seconds}");
            }
            else if (radioButtonSleep.Checked)
            {
                action = "sleep";  // Sleep
                // TODO:
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
            timeTillAction.Text = "PC will " + Properties.Settings.Default.actionName + " at";
            timeLabel.Text = Properties.Settings.Default.timeToTimer.ToString();
        }
    }
}