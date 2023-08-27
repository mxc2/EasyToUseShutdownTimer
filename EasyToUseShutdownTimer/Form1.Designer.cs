namespace EasyToUseShutdownTimer
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelWhen = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.radioButtonShutdown = new System.Windows.Forms.RadioButton();
            this.radioButtonRestart = new System.Windows.Forms.RadioButton();
            this.radioButtonSleep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTillAction = new System.Windows.Forms.Label();
            this.buttonTimerCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelWhen
            // 
            this.labelWhen.AutoSize = true;
            this.labelWhen.Location = new System.Drawing.Point(13, 19);
            this.labelWhen.Name = "labelWhen";
            this.labelWhen.Size = new System.Drawing.Size(69, 13);
            this.labelWhen.TabIndex = 2;
            this.labelWhen.Text = "Select when:";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(13, 70);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(90, 13);
            this.labelAction.TabIndex = 3;
            this.labelAction.Text = "Select what to do";
            // 
            // radioButtonShutdown
            // 
            this.radioButtonShutdown.AutoSize = true;
            this.radioButtonShutdown.Location = new System.Drawing.Point(98, 96);
            this.radioButtonShutdown.Name = "radioButtonShutdown";
            this.radioButtonShutdown.Size = new System.Drawing.Size(73, 17);
            this.radioButtonShutdown.TabIndex = 4;
            this.radioButtonShutdown.TabStop = true;
            this.radioButtonShutdown.Text = "Shutdown";
            this.radioButtonShutdown.UseVisualStyleBackColor = true;
            // 
            // radioButtonRestart
            // 
            this.radioButtonRestart.AutoSize = true;
            this.radioButtonRestart.Location = new System.Drawing.Point(98, 119);
            this.radioButtonRestart.Name = "radioButtonRestart";
            this.radioButtonRestart.Size = new System.Drawing.Size(59, 17);
            this.radioButtonRestart.TabIndex = 5;
            this.radioButtonRestart.TabStop = true;
            this.radioButtonRestart.Text = "Restart";
            this.radioButtonRestart.UseVisualStyleBackColor = true;
            // 
            // radioButtonSleep
            // 
            this.radioButtonSleep.AutoSize = true;
            this.radioButtonSleep.Location = new System.Drawing.Point(98, 142);
            this.radioButtonSleep.Name = "radioButtonSleep";
            this.radioButtonSleep.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSleep.TabIndex = 6;
            this.radioButtonSleep.TabStop = true;
            this.radioButtonSleep.Text = "Sleep";
            this.radioButtonSleep.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonSleep);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.labelWhen);
            this.groupBox1.Controls.Add(this.radioButtonRestart);
            this.groupBox1.Controls.Add(this.labelAction);
            this.groupBox1.Controls.Add(this.radioButtonShutdown);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 235);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Controls.Add(this.timeTillAction);
            this.groupBox2.Controls.Add(this.buttonTimerCancel);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 235);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(22, 65);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(50, 18);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "label1";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTillAction
            // 
            this.timeTillAction.AutoSize = true;
            this.timeTillAction.Location = new System.Drawing.Point(52, 25);
            this.timeTillAction.Name = "timeTillAction";
            this.timeTillAction.Size = new System.Drawing.Size(105, 13);
            this.timeTillAction.TabIndex = 9;
            this.timeTillAction.Text = "Action happening at:";
            // 
            // buttonTimerCancel
            // 
            this.buttonTimerCancel.Location = new System.Drawing.Point(58, 200);
            this.buttonTimerCancel.Name = "buttonTimerCancel";
            this.buttonTimerCancel.Size = new System.Drawing.Size(92, 23);
            this.buttonTimerCancel.TabIndex = 8;
            this.buttonTimerCancel.Text = "Turn off Timer";
            this.buttonTimerCancel.UseVisualStyleBackColor = true;
            this.buttonTimerCancel.Click += new System.EventHandler(this.buttonTimerCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 235);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Easy to use Shutdown timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelWhen;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.RadioButton radioButtonShutdown;
        private System.Windows.Forms.RadioButton radioButtonRestart;
        private System.Windows.Forms.RadioButton radioButtonSleep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTimerCancel;
        private System.Windows.Forms.Label timeTillAction;
        private System.Windows.Forms.Label timeLabel;
    }
}

