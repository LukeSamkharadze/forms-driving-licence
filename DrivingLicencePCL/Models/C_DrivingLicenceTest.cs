using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingLicencePCL.Services;
using DrivingLicencePCL.Other;
using DrivingLicencePCL.Extentions;

namespace DrivingLicencePCL.Models
{
    public class C_DrivingLicenceTest
    {
        public List<C_Topic> Topics { get; private set; }

        public List<C_Ticket> Tickets { get; private set; }

        public List<C_Ticket> TicketsCreated { get; private set; } = new List<C_Ticket>();

        public void CreateTickets(List<C_Topic> selectedTopics,int count)
        {
            TicketsCreated = Tickets.GetTicketsAccordingToSelectedTopicsAndCount(selectedTopics, count);
        }

        public void MarkAnswer(C_Ticket ticket, int answerID)
        {
            ticket.AnsweredAnswer = answerID;
        }

        public int Finish()
        {
            int score = 0;

            foreach (var ticketCreated in TicketsCreated)
                if(ticketCreated.AnsweredAnswer==ticketCreated.CorrectAnswer)
                    score++;

            return score;
        }

        public void Restart()
        {
            TicketsCreated.Clear();
        }

        public void Update()
        {
            Topics = C_DownloadTicketsAndTopics.GetTopicList();
            Tickets = C_DownloadTicketsAndTopics.GetTicketList();
        }
    }
}
