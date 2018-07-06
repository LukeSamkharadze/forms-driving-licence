using System.Windows.Forms;

namespace DrivingLicenceForms
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
            this.Topics_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckAll_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.UncheckAll_Button = new System.Windows.Forms.Button();
            this.TicketNumber_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Answers_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Next_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TicketsRemaining_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CorrectAnswers_Label = new System.Windows.Forms.Label();
            this.Question_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.PictureBox_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketNumber_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Topics_CheckedListBox
            // 
            this.Topics_CheckedListBox.CheckOnClick = true;
            this.Topics_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Topics_CheckedListBox.FormattingEnabled = true;
            this.Topics_CheckedListBox.HorizontalScrollbar = true;
            this.Topics_CheckedListBox.Location = new System.Drawing.Point(12, 38);
            this.Topics_CheckedListBox.Name = "Topics_CheckedListBox";
            this.Topics_CheckedListBox.Size = new System.Drawing.Size(409, 238);
            this.Topics_CheckedListBox.TabIndex = 1;
            this.Topics_CheckedListBox.Tag = "Topics_CheckedListBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topics";
            // 
            // CheckAll_Button
            // 
            this.CheckAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckAll_Button.Location = new System.Drawing.Point(12, 282);
            this.CheckAll_Button.Name = "CheckAll_Button";
            this.CheckAll_Button.Size = new System.Drawing.Size(75, 25);
            this.CheckAll_Button.TabIndex = 4;
            this.CheckAll_Button.Tag = "CheckAll_Button";
            this.CheckAll_Button.Text = "Check all";
            this.CheckAll_Button.UseVisualStyleBackColor = true;
            this.CheckAll_Button.Click += new System.EventHandler(this.CheckAll_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Start_Button.Location = new System.Drawing.Point(346, 282);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 25);
            this.Start_Button.TabIndex = 5;
            this.Start_Button.Tag = "Start_Button";
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // UncheckAll_Button
            // 
            this.UncheckAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UncheckAll_Button.Location = new System.Drawing.Point(93, 282);
            this.UncheckAll_Button.Name = "UncheckAll_Button";
            this.UncheckAll_Button.Size = new System.Drawing.Size(75, 25);
            this.UncheckAll_Button.TabIndex = 6;
            this.UncheckAll_Button.Tag = "UncheckAll_Button";
            this.UncheckAll_Button.Text = "Uncheck all";
            this.UncheckAll_Button.UseVisualStyleBackColor = true;
            this.UncheckAll_Button.Click += new System.EventHandler(this.UncheckAll_Button_Click);
            // 
            // TicketNumber_NumericUpDown
            // 
            this.TicketNumber_NumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TicketNumber_NumericUpDown.Location = new System.Drawing.Point(346, 12);
            this.TicketNumber_NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.TicketNumber_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketNumber_NumericUpDown.Name = "TicketNumber_NumericUpDown";
            this.TicketNumber_NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.TicketNumber_NumericUpDown.TabIndex = 8;
            this.TicketNumber_NumericUpDown.Tag = "TicketNumber_NumericUpDown";
            this.TicketNumber_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TicketNumber_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(240, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ticket Number";
            // 
            // Answers_CheckedListBox
            // 
            this.Answers_CheckedListBox.CheckOnClick = true;
            this.Answers_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Answers_CheckedListBox.FormattingEnabled = true;
            this.Answers_CheckedListBox.HorizontalScrollbar = true;
            this.Answers_CheckedListBox.Location = new System.Drawing.Point(12, 586);
            this.Answers_CheckedListBox.Name = "Answers_CheckedListBox";
            this.Answers_CheckedListBox.Size = new System.Drawing.Size(1428, 238);
            this.Answers_CheckedListBox.TabIndex = 11;
            this.Answers_CheckedListBox.Tag = "Answers_CheckedListBox";
            this.Answers_CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Answers_CheckedListBox_ItemCheckChanged);
            // 
            // Next_Button
            // 
            this.Next_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Next_Button.Location = new System.Drawing.Point(675, 830);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(75, 25);
            this.Next_Button.TabIndex = 12;
            this.Next_Button.Tag = "Next_Button";
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(433, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tickets Remaining";
            // 
            // TicketsRemaining_Label
            // 
            this.TicketsRemaining_Label.AutoSize = true;
            this.TicketsRemaining_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TicketsRemaining_Label.Location = new System.Drawing.Point(563, 293);
            this.TicketsRemaining_Label.Name = "TicketsRemaining_Label";
            this.TicketsRemaining_Label.Size = new System.Drawing.Size(18, 17);
            this.TicketsRemaining_Label.TabIndex = 14;
            this.TicketsRemaining_Label.Tag = "TicketsRemaining_Label";
            this.TicketsRemaining_Label.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(446, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Correct Answers";
            // 
            // CorrectAnswers_Label
            // 
            this.CorrectAnswers_Label.AutoSize = true;
            this.CorrectAnswers_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CorrectAnswers_Label.Location = new System.Drawing.Point(563, 276);
            this.CorrectAnswers_Label.Name = "CorrectAnswers_Label";
            this.CorrectAnswers_Label.Size = new System.Drawing.Size(18, 17);
            this.CorrectAnswers_Label.TabIndex = 16;
            this.CorrectAnswers_Label.Tag = "CorrectAnswers_Label";
            this.CorrectAnswers_Label.Text = "N";
            // 
            // Question_RichTextBox
            // 
            this.Question_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Question_RichTextBox.Location = new System.Drawing.Point(12, 313);
            this.Question_RichTextBox.Name = "Question_RichTextBox";
            this.Question_RichTextBox.ReadOnly = true;
            this.Question_RichTextBox.Size = new System.Drawing.Size(569, 267);
            this.Question_RichTextBox.TabIndex = 17;
            this.Question_RichTextBox.Tag = "Question_RichTextBox";
            this.Question_RichTextBox.Text = "";
            // 
            // PictureBox_PictureBox
            // 
            this.PictureBox_PictureBox.Location = new System.Drawing.Point(587, 12);
            this.PictureBox_PictureBox.Name = "PictureBox_PictureBox";
            this.PictureBox_PictureBox.Size = new System.Drawing.Size(853, 568);
            this.PictureBox_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_PictureBox.TabIndex = 18;
            this.PictureBox_PictureBox.TabStop = false;
            this.PictureBox_PictureBox.Tag = "PictureBox_PictureBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 867);
            this.Controls.Add(this.PictureBox_PictureBox);
            this.Controls.Add(this.Question_RichTextBox);
            this.Controls.Add(this.CorrectAnswers_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketsRemaining_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Answers_CheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketNumber_NumericUpDown);
            this.Controls.Add(this.UncheckAll_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.CheckAll_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Topics_CheckedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TicketNumber_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Topics_CheckedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckAll_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button UncheckAll_Button;
        private System.Windows.Forms.NumericUpDown TicketNumber_NumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Answers_CheckedListBox;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TicketsRemaining_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CorrectAnswers_Label;
        private System.Windows.Forms.RichTextBox Question_RichTextBox;
        private System.Windows.Forms.PictureBox PictureBox_PictureBox;
    }
}

