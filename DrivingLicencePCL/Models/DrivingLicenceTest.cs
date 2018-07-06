using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingLicencePCL.Extentions;

namespace DrivingLicencePCL.Models
{
    public class DrivingLicenceTest
    {
        public List<Topic> Topics { get; private set; }

        public List<Topic> SelectedTopics { get; private set; } = new List<Topic>();

        public List<Ticket> Tickets { get; private set; }

        public List<Ticket> TicketsUsed { get; private set; } = new List<Ticket>();

        public Ticket CurrentTicket { get; private set; }

        public int TicketsRemaining { get; set; }

        public int CorrectAnswers { get; private set; }

        public IEnumerable<string> GetCurrentTicketAnswers()
        {
            return CurrentTicket.Answers.TakeSubstringsByEncolsingChar('"');
        }

        public string GetCurrentTicketPicturePath()
        {
            return DrivingLicenceServerPCL.Services.Services.DownloadImage(CurrentTicket.Filename);
        }

        public void CreateNewTicket()
        {
            if(SelectedTopics.Count < 1)
                throw new Exception("SelectedTopics is less than 1");

            if (TicketsRemaining < 1)
                throw new Exception("TicketsRemaining is less than 1");

            TicketsRemaining--;

            CurrentTicket = Tickets.Where((o)=>
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

                foreach (var ticket in TicketsUsed)
                    if (o == ticket)
                        return false;

                return flag;
            }).RandomElement();

            TicketsUsed.Add(CurrentTicket);
        }

        public bool TryAnswer(int ID)
        {
            if( CurrentTicket.CorrectAnswer == ID )
            {
                CorrectAnswers++;
                return true;
            }

            return false;
        }

        public void Update()
        {
            Topics = Services.Services.GetTopicList();
            Tickets = Services.Services.GetTicketList();
        }
    }
}
