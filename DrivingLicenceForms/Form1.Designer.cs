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
            this.Question_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.PictureBox_PictureBox = new System.Windows.Forms.PictureBox();
            this.Previous_Button = new System.Windows.Forms.Button();
            this.Finish_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketNumber_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Topics_CheckedListBox
            // 
            this.Topics_CheckedListBox.CheckOnClick = true;
            this.Topics_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.Topics_CheckedListBox.FormattingEnabled = true;
            this.Topics_CheckedListBox.HorizontalScrollbar = true;
            this.Topics_CheckedListBox.Location = new System.Drawing.Point(12, 38);
            this.Topics_CheckedListBox.Name = "Topics_CheckedListBox";
            this.Topics_CheckedListBox.Size = new System.Drawing.Size(569, 235);
            this.Topics_CheckedListBox.TabIndex = 1;
            this.Topics_CheckedListBox.Tag = "Topics_CheckedListBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topics";
            // 
            // CheckAll_Button
            // 
            this.CheckAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckAll_Button.Location = new System.Drawing.Point(12, 276);
            this.CheckAll_Button.Name = "CheckAll_Button";
            this.CheckAll_Button.Size = new System.Drawing.Size(240, 37);
            this.CheckAll_Button.TabIndex = 4;
            this.CheckAll_Button.Tag = "CheckAll_Button";
            this.CheckAll_Button.Text = "Check all";
            this.CheckAll_Button.UseVisualStyleBackColor = true;
            this.CheckAll_Button.Click += new System.EventHandler(this.CheckAll_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Start_Button.Location = new System.Drawing.Point(506, 276);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 37);
            this.Start_Button.TabIndex = 5;
            this.Start_Button.Tag = "Start_Button";
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // UncheckAll_Button
            // 
            this.UncheckAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UncheckAll_Button.Location = new System.Drawing.Point(260, 276);
            this.UncheckAll_Button.Name = "UncheckAll_Button";
            this.UncheckAll_Button.Size = new System.Drawing.Size(240, 37);
            this.UncheckAll_Button.TabIndex = 6;
            this.UncheckAll_Button.Tag = "UncheckAll_Button";
            this.UncheckAll_Button.Text = "Uncheck";
            this.UncheckAll_Button.UseVisualStyleBackColor = true;
            this.UncheckAll_Button.Click += new System.EventHandler(this.UncheckAll_Button_Click);
            // 
            // TicketNumber_NumericUpDown
            // 
            this.TicketNumber_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TicketNumber_NumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TicketNumber_NumericUpDown.Location = new System.Drawing.Point(506, 9);
            this.TicketNumber_NumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.TicketNumber_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketNumber_NumericUpDown.Name = "TicketNumber_NumericUpDown";
            this.TicketNumber_NumericUpDown.Size = new System.Drawing.Size(75, 26);
            this.TicketNumber_NumericUpDown.TabIndex = 8;
            this.TicketNumber_NumericUpDown.Tag = "TicketNumber_NumericUpDown";
            this.TicketNumber_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TicketNumber_NumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(382, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ticket Number";
            // 
            // Answers_CheckedListBox
            // 
            this.Answers_CheckedListBox.CheckOnClick = true;
            this.Answers_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.Answers_CheckedListBox.FormattingEnabled = true;
            this.Answers_CheckedListBox.HorizontalScrollbar = true;
            this.Answers_CheckedListBox.Location = new System.Drawing.Point(12, 586);
            this.Answers_CheckedListBox.Name = "Answers_CheckedListBox";
            this.Answers_CheckedListBox.Size = new System.Drawing.Size(1428, 235);
            this.Answers_CheckedListBox.TabIndex = 11;
            this.Answers_CheckedListBox.Tag = "Answers_CheckedListBox";
            this.Answers_CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Answers_CheckedListBox_ItemCheck);
            // 
            // Next_Button
            // 
            this.Next_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Next_Button.Location = new System.Drawing.Point(689, 824);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(670, 37);
            this.Next_Button.TabIndex = 12;
            this.Next_Button.Tag = "Next_Button";
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Question_RichTextBox
            // 
            this.Question_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Question_RichTextBox.Location = new System.Drawing.Point(12, 319);
            this.Question_RichTextBox.Name = "Question_RichTextBox";
            this.Question_RichTextBox.ReadOnly = true;
            this.Question_RichTextBox.Size = new System.Drawing.Size(569, 261);
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
            // Previous_Button
            // 
            this.Previous_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Previous_Button.Location = new System.Drawing.Point(12, 824);
            this.Previous_Button.Name = "Previous_Button";
            this.Previous_Button.Size = new System.Drawing.Size(670, 37);
            this.Previous_Button.TabIndex = 19;
            this.Previous_Button.Tag = "Previous_Button";
            this.Previous_Button.Text = "Previous";
            this.Previous_Button.UseVisualStyleBackColor = true;
            this.Previous_Button.Click += new System.EventHandler(this.Previous_Button_Click);
            // 
            // Finish_Button
            // 
            this.Finish_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Finish_Button.Location = new System.Drawing.Point(1365, 824);
            this.Finish_Button.Name = "Finish_Button";
            this.Finish_Button.Size = new System.Drawing.Size(75, 37);
            this.Finish_Button.TabIndex = 20;
            this.Finish_Button.Tag = "Finish_Button";
            this.Finish_Button.Text = "Finish";
            this.Finish_Button.UseVisualStyleBackColor = true;
            this.Finish_Button.Click += new System.EventHandler(this.Finish_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 867);
            this.Controls.Add(this.Finish_Button);
            this.Controls.Add(this.Previous_Button);
            this.Controls.Add(this.PictureBox_PictureBox);
            this.Controls.Add(this.Question_RichTextBox);
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
        private System.Windows.Forms.RichTextBox Question_RichTextBox;
        private System.Windows.Forms.PictureBox PictureBox_PictureBox;
        private Button Previous_Button;
        private Button Finish_Button;
    }
}

