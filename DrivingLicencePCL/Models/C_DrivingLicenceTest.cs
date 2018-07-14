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

        public C_TVarHandler<int> TicketsRemaining { get; private set; } = new C_TVarHandler<int>();

        public void CreateTickets(List<C_Topic> selectedTopics,int count)
        {
            TicketsRemaining.Data = count;
            TicketsCreated = Tickets.GetTicketsAccordingToSelectedTopicsAndCount(selectedTopics, count);
        }

        public void MarkAnswer(C_Ticket ticket, int answerID)
        {
            if (ticket.AnsweredAnswer == null)
                TicketsRemaining.Data--;
            ticket.AnsweredAnswer = answerID;
        }

        public void Restart()
        {
            TicketsCreated.Clear();

            TicketsRemaining.Data = 0;
        }

        public void Update()
        {
            Topics = C_DownloadTicketsAndTopics.GetTopicList();
            Tickets = C_DownloadTicketsAndTopics.GetTicketList();
        }
    }
}
