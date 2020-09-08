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

using DrivingLicencePCL.Services;
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

            _DrivingLicenceTest.Update();

            foreach (var topic in _DrivingLicenceTest.Topics)
                Topics_CheckedListBox.Items.Add(topic, false);
        }

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
            _DrivingLicenceTest.Restart();

            List<C_Topic> selectedTopics = new List<C_Topic>();

            foreach (var topic in Topics_CheckedListBox.CheckedItems)
                    selectedTopics.Add(topic as C_Topic);

            _DrivingLicenceTest.CreateTickets(selectedTopics, (int)TicketNumber_NumericUpDown.Value);

            CurrentTicketDisplayedIndex = 0;

            DisplayTicket();
        }
      
        private void DisplayTicket()
        {
            Question_RichTextBox.Text = _DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex].Question;

            try
            {
                PictureBox_PictureBox.Image = Image.FromFile(C_DownloadImage.DownloadImage(_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex].Filename));
            }
            catch
            {
                PictureBox_PictureBox.Image = null;
            }

            Answers_CheckedListBox.Items.Clear();

            int answerID = 0;

            foreach (var answer in _DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex].Answers.TakeSubstringsByEncolsingChar('"'))
                Answers_CheckedListBox.Items.Add(answer, (_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex].AnsweredAnswer == answerID++) ? true : false);
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            if (CurrentTicketDisplayedIndex != _DrivingLicenceTest.TicketsCreated.Count - 1)
                CurrentTicketDisplayedIndex++;
            else
                return;

            DisplayTicket();
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            if (CurrentTicketDisplayedIndex != 0)
                CurrentTicketDisplayedIndex--;
            else
                return;

            DisplayTicket();
        }

        private void Answers_CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < Answers_CheckedListBox.Items.Count; ++ix)
                if (ix != e.Index) Answers_CheckedListBox.SetItemChecked(ix, false);

            if (Answers_CheckedListBox.CheckedIndices.Count == 1)
            {
                Console.WriteLine("zd");
                _DrivingLicenceTest.MarkAnswer(_DrivingLicenceTest.TicketsCreated[CurrentTicketDisplayedIndex], Answers_CheckedListBox.CheckedIndices[0]);

            }
        }

        private void Finish_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Correct Answers : {_DrivingLicenceTest.Finish()}");
        }
    }
}
