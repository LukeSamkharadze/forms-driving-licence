using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingLicencePCL.Other;
using DrivingLicencePCL.Extentions;

namespace DrivingLicencePCL.Models
{
    public class C_DrivingLicenceTest
    {
        public List<C_Topic> Topics { get; private set; }

        public List<C_Ticket> Tickets { get; private set; }

        public List<C_Topic> SelectedTopics { get; private set; } = new List<C_Topic>();

        public List<C_Ticket> TicketsCreated { get; private set; } = new List<C_Ticket>();

        public C_TVarHandler<int> TicketsRemaining { get; private set; } = new C_TVarHandler<int>();

        public C_TVarHandler<int> CorrectAnswers { get; private set; } = new C_TVarHandler<int>();
        
        public IEnumerable<string> GetTicketAnswers(C_Ticket ticket)
        {
            return ticket.Answers.TakeSubstringsByEncolsingChar('"');
            //
        }

        public string GetPicturePath(C_Ticket ticket)
        {
            return DrivingLicenceServerPCL.Services.Services.DownloadImage(ticket.Filename);
        }

        public void CreateNewTicket()
        {
            if(SelectedTopics.Count < 1)
                throw new Exception("SelectedTopics is less than 1");

            if (TicketsRemaining.Data < 1)
                throw new Exception("TicketsRemaining is less than 1");

            TicketsCreated.Add(Tickets.Where((o) =>
            {
                bool flag = false;
                foreach (var topic in SelectedTopics)
                    if (o.Topic == topic.Id)
                    {
                        flag = true;
                        break;
                    }

                if (flag == false)
                    return false;

                foreach (var ticket in TicketsCreated)
                    if (o == ticket)
                        return false;

                return flag;
            }).RandomElement());
        }

        public bool Answer(C_Ticket ticket,int answerID)
        {
            TicketsRemaining.Data--;
            ticket.AnsweredAnswer = answerID;
            if (ticket.CorrectAnswer == answerID)
            {
                CorrectAnswers.Data++;
                return true;
            }

            return false;
        }

        public void Update()
        {
            Topics = Services.C_Services.GetTopicList();
            Tickets = Services.C_Services.GetTicketList();
        }
    }
}
