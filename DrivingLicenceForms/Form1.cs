using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DrivingLicencePCL.Other;
using DrivingLicencePCL.Extentions;

using DrivingLicencePCL.Models;

namespace DrivingLicenceForms
{
    public partial class Form1 : Form
    {
        private C_DrivingLicenceTest _DrivingLicenceTest { get; } = new C_DrivingLicenceTest();

        private int CurrentTicketDisplayedIndex { get; set; } = -1;

        public Form1()
        {
            InitializeComponent();

            // Updating(Downloading) Topics and Tickets
            _DrivingLicenceTest.Update();

            // Topics_CheckedListBox adding CheckBoxes
            foreach (var topic in _DrivingLicenceTest.Topics)
                Topics_CheckedListBox.Items.Add(topic, false);
        }

        // First Section
        private void CheckAll_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Topics_CheckedListBox.Items.Count; i++)
                Topics_CheckedListBox.SetItemChecked(i, true);
        }
        private void UncheckAll_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Topics_CheckedListBox.Items.Count; i++)
                Topics_CheckedListBox.SetItemChecked(i, false);
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            _DrivingLicenceTest.CorrectAnswers.subscribers += (s, ee) => CorrectAnswers_Label.Text = ee.ToString();
            _DrivingLicenceTest.TicketsRemaining.subscribers += (s, ee) => TicketsRemaining_Label.Text = ee.ToString();

            CorrectAnswers_Label.Text = "0";
            _DrivingLicenceTest.TicketsRemaining.Data = (int)TicketNumber_NumericUpDown.Value;

            // Moving selected topics to _DrivingLicenceTest.SelectedTopics
            foreach (var topic in Topics_CheckedListBox.CheckedItems)  
                    _DrivingLicenceTest.SelectedTopics.Add(topic as C_Topic);

            // Create new ticket
            _DrivingLicenceTest.CreateNewTicket();

            // Displaying ticket
            DisplayTicket(_DrivingLicenceTest.TicketsCreated.Last());

            // CurrentTicketDisplayedIndex
            CurrentTicketDisplayedIndex = 0;
        }
      
        // Second Section
        private void DisplayTicket(C_Ticket ticket)
        {
            Question_RichTextBox.Text = ticket.Question;
            try
            {
                PictureBox_PictureBox.Image = Image.FromFile(_DrivingLicenceTest.GetPicturePath(ticket));
            }
            catch
            {
                PictureBox_PictureBox.Image = null;
            }

            Answers_CheckedListBox.Items.Clear();
            int answerID = 0;
            foreach (var answer in _DrivingLicenceTest.GetTicketAnswers(ticket))
            {
                Answers_CheckedListBox.Items.Add(answer, (ticket.AnsweredAnswer == answerID++) ? true : false);
                Console.WriteLine("added buttons " + answerID);
            }
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            // increasing CurrentTicketDisplayedIndex
            CurrentTicketDisplayedIndex++;

            if(CurrentTicketDisplayedIndex >= _DrivingLicenceTest.TicketsCreated.Count)
             _DrivingLicenceTest.CreateNewTicket();

            // display next ticket
            DisplayTicket(_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex]);
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            // decreasing CurrentTicketDisplayedIndex
            if (CurrentTicketDisplayedIndex > 0)
                CurrentTicketDisplayedIndex--;

            // display previous ticket
            DisplayTicket(_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex]);
        }


        private void Answer_Button_Click(object sender, EventArgs e)
        {
            // if nothing is checked
            if (Answers_CheckedListBox.CheckedItems.Count == 0)
                return;

            if (_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex].AnsweredAnswer != null)
                return;

            // answer
            _DrivingLicenceTest.Answer(_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex],(Answers_CheckedListBox.CheckedIndices[0]));
        }

        private void Answers_CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex].AnsweredAnswer != null)
            {
                Console.WriteLine("some shit");
                e.NewValue = e.CurrentValue;
                return;
            }

            //(sender as CheckedListBox).check

            for (int i = 0; i < Answers_CheckedListBox.Items.Count; ++i)
                if (i != e.Index)
                    Answers_CheckedListBox.SetItemChecked(i, false);
        }
    }
}
