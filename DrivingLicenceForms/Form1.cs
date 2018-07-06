using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DrivingLicencePCL.Extentions;

using DrivingLicencePCL.Models;

namespace DrivingLicenceForms
{
    public partial class Form1 : Form
    {
        private DrivingLicenceTest _DrivingLicenceTest { get; } = new DrivingLicenceTest();

        public Form1()
        {
            InitializeComponent();

            _DrivingLicenceTest.Update();

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
            _DrivingLicenceTest.TicketsRemaining = (int)TicketNumber_NumericUpDown.Value;

            /////////////////////////////////////////////////////////////////////////
            foreach (var topic in Topics_CheckedListBox.CheckedItems)  
                    _DrivingLicenceTest.SelectedTopics.Add(topic as Topic);

            DisplayNewTicket();
        }

        // Second Section
        private void Next_Button_Click(object sender, EventArgs e)
        {
            if (Answers_CheckedListBox.CheckedItems.Count == 0)
                return;

            _DrivingLicenceTest.TryAnswer((Answers_CheckedListBox.CheckedIndices[0]));

            DisplayNewTicket();
        }

        private void DisplayNewTicket()
        {
            _DrivingLicenceTest.CreateNewTicket();

            ////////////////////////////////////////////////////////////////////////////
            CorrectAnswers_Label.Text = _DrivingLicenceTest.CorrectAnswers.ToString();
            TicketsRemaining_Label.Text = _DrivingLicenceTest.TicketsRemaining.ToString();

            Question_RichTextBox.Text = _DrivingLicenceTest.CurrentTicket.Question;
            try
            {
                PictureBox_PictureBox.Image = Image.FromFile(_DrivingLicenceTest.GetCurrentTicketPicturePath());
            }
            catch
            {
                PictureBox_PictureBox.Image = null;
            }

            Answers_CheckedListBox.Items.Clear();
            foreach (var answer in _DrivingLicenceTest.GetCurrentTicketAnswers())
                Answers_CheckedListBox.Items.Add(answer, false);
        }

        private void Answers_CheckedListBox_ItemCheckChanged(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < Answers_CheckedListBox.Items.Count; ++ix)
                if (ix != e.Index)
                    Answers_CheckedListBox.SetItemChecked(ix, false);
        }
    }
}
