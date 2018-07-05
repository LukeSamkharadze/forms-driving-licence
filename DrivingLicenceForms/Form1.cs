using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DrivingLicencePCL.Models;

namespace DrivingLicenceForms
{
    public partial class Form1 : Form
    {
        private Ticket _CurrentQuestion { get; set; }

        private int QuestionNumber { get; set; }

        private int CorrectAnswers { get; set; }

        public Form1()
        {
            InitializeComponent();

            foreach (var topic in DrivingLicencePCL.Services.Services.GetTopicList())
            {
                Topics_CheckedListBox.Items.Add(topic, false);
            }
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

        }

        // Second Section
        private void Next_Button_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
